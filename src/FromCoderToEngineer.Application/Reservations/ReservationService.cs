namespace FromCoderToEngineer.Application.Reservations
{
    using System;
    using System.Linq;
    using FromCoderToEngineer.Application.DataAccess;
    using FromCoderToEngineer.Application.Emails;
    using FromCoderToEngineer.Application.Models;

    public class ReservationService : IReservationService
    {
        public EmailClient EmailClient { get; set; }

        public ReservationService()
        {
            EmailClient = new EmailClient();
        }

        public bool CreateReservation(string name, int partySize, DateTime reservationTime)
        {
            if (reservationTime < DateTime.Now || name == null)
            {
                return false;
            }

            var lastName = name.Split(" ")[1];

            Customer customer;
            Reservation reservation;

            using (var context = new DatabaseContext())
            {
                customer = context.Customers.First(x => x.LastName == lastName);

                reservation = new Reservation
                {
                    Id = Guid.NewGuid(),
                    DateTime = reservationTime,
                };

                customer.Reservations.Add(reservation);

                context.SaveChanges();
            }

            EmailClient.SendEmail(customer.Email, $"{customer.FirstName} {customer.LastName}");

            return true;
        }
    }
}
