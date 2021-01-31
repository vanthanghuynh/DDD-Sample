using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public ClientRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Client client)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (client.Id == null)
                {
                    query = $@"INSERT INTO Client(Id, FirstName, LastName) 
                               VALUES(@Id, @FirstName, @LastName)";
                }
                else
                {
                    query = $@"UPDATE Client SET
                               FirstName = @FirstName
                              ,LastName = @LastName
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = client.Id == null ? Guid.NewGuid() : client.Id,
                    client.FirstName,
                    client.LastName,
                }, commandType: CommandType.Text);
            }
        }
    }
}
