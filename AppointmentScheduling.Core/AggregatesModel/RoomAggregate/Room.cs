using AppointmentScheduling.Core.Common;
using System;

namespace AppointmentScheduling.Core.AggregatesModel
{
    public class Room : Entity<Guid>
    {
        public string Name { get; private set; }
    }
}
