using AppointmentScheduling.Core.Common;
using AppointmentScheduling.Core.CommonValueObjects;
using System;
using System.Collections.Generic;

namespace AppointmentScheduling.Core.AggregatesModel.ScheduleAggregate
{
    public class Schedule : Entity<Guid>
    {
        public int ClinicId { get; private set; }

        public DateTimeRange DateRange { get; private set; }

        public List<Appointment> Appointments { get; private set; }
    }
}
