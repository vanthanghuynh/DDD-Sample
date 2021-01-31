using AppointmentScheduling.Core.Common;
using System;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class Doctor : Entity<Guid>
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
