using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class AppointmentTypeRepository : IAppointmentTypeRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public AppointmentTypeRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(AppointmentType appointmentType)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (appointmentType.Id == null)
                {
                    query = $@"INSERT INTO AppointmentType(Id, Name, Code, Duration) 
                               VALUES(@Id, @Name, @Code, @Duration)";
                }
                else
                {
                    query = $@"UPDATE AppointmentType SET
                               Name = @Name
                              ,Code = @Code
                              ,Duration = @Duration
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = appointmentType.Id == null ? Guid.NewGuid() : appointmentType.Id,
                    appointmentType.Name,
                    appointmentType.Code,
                    appointmentType.Duration
                }, commandType: CommandType.Text);
            }
        }
    }
}
