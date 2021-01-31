using AppointmentScheduling.Core.Common;
using AppointmentScheduling.Core.CommonValueObjects;
using System;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class Appointment : Entity<Guid>
    {
        public Guid ClientId { get; private set; }

        public Guid PatientId { get; private set; }

        public Guid RoomId { get; private set; }

        public Guid DoctorId { get; private set; }

        public Guid AppointmentTypeId { get; private set; }

        public Guid ScheduleId { get; private set; }

        public DateTimeRange TimeRange { get; private set; }

        public string Title { get; private set; }
    }
}
