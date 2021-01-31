using AppointmentScheduling.Core.Common;
using System;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class AppointmentType : Entity<Guid>
    {
        public string Name { get; private set; }

        public string Code { get; private set; }

        public int Duration { get; private set; }
    }
}
