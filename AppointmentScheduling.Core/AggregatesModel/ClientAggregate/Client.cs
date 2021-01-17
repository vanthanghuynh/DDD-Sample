using AppointmentScheduling.Core.Common;
using System;
using System.Collections.Generic;

namespace AppointmentScheduling.Core.AggregatesModel.ClientAggregate
{
    public class Client : Entity<Guid>
    {
        public string FullName { get; private set; }

        public IList<Patient> Patients { get; private set; }
    }
}
