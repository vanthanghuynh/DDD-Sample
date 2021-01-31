using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public DoctorRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Doctor doctor)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (doctor.Id == null)
                {
                    query = $@"INSERT INTO Doctor(Id, FirstName, LastName) 
                               VALUES(@Id, @FirstName, @LastName)";
                }
                else
                {
                    query = $@"UPDATE Doctor SET
                               FirstName = @FirstName
                              ,LastName = @LastName
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = doctor.Id == null ? Guid.NewGuid() : doctor.Id,
                    doctor.FirstName,
                    doctor.LastName,
                }, commandType: CommandType.Text);
            }
        }
    }
}
