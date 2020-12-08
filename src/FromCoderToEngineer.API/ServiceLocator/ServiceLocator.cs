namespace FromCoderToEngineer.API.ServiceLocator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using FromCoderToEngineer.Application.Reservations;

    public class ServiceLocator
    {
        private readonly Dictionary<Type, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<Type, object>
            {
                { typeof(IReferenceService), new ReservationService() },
            };
        }

        public T GetService<T>()
        {
            return (T)_services[typeof(T)];
        }
    }
}
