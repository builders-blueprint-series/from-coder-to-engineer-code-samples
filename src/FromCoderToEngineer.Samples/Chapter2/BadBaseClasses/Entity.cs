using System;

namespace FromCoderToEngineer.Samples.Chapter2.BadBaseClasses
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}