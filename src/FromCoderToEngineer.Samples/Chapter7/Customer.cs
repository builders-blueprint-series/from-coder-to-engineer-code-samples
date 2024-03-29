﻿using System;

namespace FromCoderToEngineer.Samples.Chapter7
{
    public class Customer
    {
        public Customer(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public string MaskedId()
        {
            const int startingIndex = 0;
            const int length = 8;

            return Id.ToString().Substring(startingIndex, length);
        }
    }
}