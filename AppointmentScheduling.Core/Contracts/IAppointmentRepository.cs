using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Common;

namespace AppointmentScheduling.Core.Contracts
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
    }
}