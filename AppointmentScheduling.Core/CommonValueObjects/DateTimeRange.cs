using System;

namespace AppointmentScheduling.Core.CommonValueObjects
{
    public class DateTimeRange
    {
        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }
    }
}
