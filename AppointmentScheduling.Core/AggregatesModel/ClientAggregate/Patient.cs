﻿using AppointmentScheduling.Core.ClientValueObjects;
using AppointmentScheduling.Core.Common;
using System;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class Patient : Entity<Guid>
    {
        public Guid ClientId { get; private set; }

        public string Name { get; private set; }

        public GenderType Gender { get; private set; }

        public AnimalType AnimalType { get; private set; }
    }
}
