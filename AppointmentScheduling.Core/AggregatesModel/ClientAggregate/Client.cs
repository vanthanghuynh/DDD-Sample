using AppointmentScheduling.Core.Common;
using System;
using System.Collections.Generic;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class Client : Entity<Guid>
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public IList<Patient> Patients { get; private set; }
    }
}
