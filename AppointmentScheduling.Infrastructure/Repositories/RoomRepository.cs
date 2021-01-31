using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public RoomRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Room room)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if (room.Id == null)
                {
                    query = $@"INSERT INTO Room(Id, Name) 
                               VALUES(@Id, @Name)";
                }
                else
                {
                    query = $@"UPDATE Room SET
                               Name = @Name
                              WHERE Id = @Id";
                }

                await connection.QueryAsync(query, new
                {
                    Id = room.Id == null ? Guid.NewGuid() : room.Id,
                    room.Name
                }, commandType: CommandType.Text);
            }
        }
    }
}
