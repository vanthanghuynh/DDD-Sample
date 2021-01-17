using System;

namespace AppointmentScheduling.Core.CommonValueObjects
{
    public class DateTimeRange
    {
        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }
    }
}
