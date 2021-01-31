using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public AppointmentRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Appointment appointment)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (appointment.Id == null)
                {
                    query = $@"INSERT INTO Appointment(Id, ClientId, PatientId, RoomId, DoctorId, AppointmentTypeId, ScheduleId, StartDate, EndDate, Title) 
                               VALUES(@Id, @ClientId, @PatientId, @RoomId, @DoctorId, @AppointmentTypeId, @ScheduleId, @StartTime, @EndTime, @Title)";
                }
                else
                {
                    query = $@"UPDATE Appointment SET
                               ClientId = @ClientId
                               PatientId = @PatientId
                               RoomId = @RoomId
                               DoctorId = @DoctorId
                               AppointmentTypeId = @AppointmentTypeId
                               ScheduleId = @ScheduleId
                               StartTime = @StartTime
                               EndTime = @EndTime
                               Title = @Title
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = appointment.Id == null ? Guid.NewGuid() : appointment.Id,
                    appointment.ClientId,
                    appointment.PatientId,
                    appointment.RoomId,
                    appointment.DoctorId,
                    appointment.AppointmentTypeId,
                    appointment.ScheduleId,
                    appointment.TimeRange.StartTime,
                    appointment.TimeRange.EndTime,
                    appointment.Title,

                }, commandType: CommandType.Text);
            }
        }
    }
}
