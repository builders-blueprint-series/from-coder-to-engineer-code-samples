using System;
using System.Collections.Generic;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter5.GodClasses
{
    public abstract class Entity
    {
        private readonly ICollection<INotification> _notifications;

        protected Entity()
        {
            _notifications = new List<INotification>();
        }

        public IReadOnlyList<INotification> Notifications => _notifications.ToList();

        protected void AddNotification(INotification notification)
        {
            if (notification == null)
            {
                throw new NullReferenceException(nameof(notification));
            }

            _notifications.Add(notification);
        }
    }
}
