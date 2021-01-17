using AppointmentScheduling.Core.Common;
using System;

namespace AppointmentScheduling.Core.AggregatesModel.DoctorAggregate
{
    public class Doctor : Entity<Guid>
    {
        public string FisrtName { get; private set; }

        public string LastName { get; private set; }
    }
}
