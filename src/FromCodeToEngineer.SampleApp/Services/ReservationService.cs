namespace FromCodeToEngineer.SampleApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Requests;
    using Serilog;

    public class ReservationService
    {
        public ReservationService()
        {
            Context = new DatabaseContext();
            SmtpService = new SmtpService();
        }

        public static ILogger Logger { get; set; } = Logger.ForContext<ReservationService>();

        public DatabaseContext Context { get; set; }

        public SmtpService SmtpService { get; set; }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return Context.Reservations.Include(x => x.Customer);
        }

        public IEnumerable<Reservation> GetAllReservations(DateTime min, DateTime max)
        {
            return Context.Reservations.Where(x => x.DateTime >= min && x.DateTime <= max).Include(x => x.Customer);
        }

        public Reservation AddReservation(AddReservation request)
        {
            var customer = Context.Customers.Find(request.CustomerId);

            if (customer == null)
            {
                Logger.Error("Customer not found.");
                throw new NullReferenceException("Customer does not exist.");
            }

            var reservation = new Reservation { Id = Guid.NewGuid(), DateTime = request.DateTime, Customer = customer };

            try
            {
                Context.Reservations.Add(reservation);
                Context.SaveChanges();

                SmtpService.SendEmail(customer.Email, $"Your reservation at {request.DateTime} has been reserved.");

                customer.TotalReservations++;
                DetermineStatus(customer);

                return reservation;
            }
            catch (Exception exception)
            {
                Logger.Error($"Reservation for {customer.Id} at {request.DateTime} failed.");

                throw exception;
            }
        }

        public void DeleteReservation(Guid reservationId)
        {
            var reservation = Context.Reservations
                .Include(x => x.Customer)
                .First(x => x.Id == reservationId);

            if (reservation == null)
            {
                Logger.Error("Reservation not found.");
                throw new NullReferenceException("Reservation does not exist.");
            }

            if (reservation.DateTime <= DateTime.Now)
            {
                throw new ArgumentException("Reservation is in the past.");
            }

            try
            {
                var customer = reservation.Customer;

                customer.TotalReservations--;
                Context.Reservations.Remove(reservation);
                DetermineStatus(customer);
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Reservation could not be deleted.");
                throw;
            }
        }

        private void DetermineStatus(Customer customer)
        {
            var currentStatus = customer.Status;

            if (customer.TotalReservations >= 10)
            {
                customer.Status = Status.Silver;
            }
            else if (customer.TotalReservations >= 20)
            {
                customer.Status = Status.Gold;
            }

            if (currentStatus != customer.Status)
            {
                SmtpService.SendEmail(customer.Email, $"Your status has changed. You are now {customer.Status}!");
                Context.Customers.Update(customer);
            }
        }
    }
}
