using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public ScheduleRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Schedule schedule)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (schedule.Id == null)
                {
                    query = $@"INSERT INTO Schedule(Id, ClinicId, StartDate, EndDate) 
                               VALUES(@Id, @ClinicId, @StartDate, @EndDate)";
                }
                else
                {
                    query = $@"UPDATE Schedule SET
                               ClinicId = @ClinicId
                               ,StartDate = @StartDate
                               ,EndDate = @EndDate
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = schedule.Id == null ? Guid.NewGuid() : schedule.Id,
                    schedule.ClinicId,
                    schedule.DateRange.StartTime,
                    schedule.DateRange.EndTime
                }, commandType: CommandType.Text);
            }
        }
    }
}
