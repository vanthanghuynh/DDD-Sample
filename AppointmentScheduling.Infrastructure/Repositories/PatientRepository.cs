using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.SqlConnectionProvider;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppointmentScheduling.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly SchedulingConnectionProvider schedulingConnectionProvider;

        public PatientRepository(SchedulingConnectionProvider schedulingConnectionProvider)
        {
            this.schedulingConnectionProvider = schedulingConnectionProvider;
        }

        public async Task SaveAsync(Patient patient)
        {
            using (var connection = this.schedulingConnectionProvider.CreateConnection())
            {
                var query = string.Empty;

                if(patient.Id == null)
                {
                    query = $@"INSERT INTO Patient(Id, Name, Gender, AnimalTypeId, ClientId, Species, Breed) 
                               VALUES(@Id, @Name, @Gender, @AnimalTypeId, @ClientId, @Species, @Breed)";
                }
                else
                {
                    query = $@"UPDATE Patient SET
                               Name = @Name
                              ,Gender = @Gender
                              ,AnimalTypeId = @AnimalTypeId
                              ,ClientId = @ClientId,
                              ,Species = @Species,
                              ,Breed = @Breed
                              WHERE Id = @Id";
                }
                
                await connection.QueryAsync(query, new
                {
                    Id = patient.Id == null ? Guid.NewGuid() : patient.Id,
                    patient.Name,
                    patient.Gender,
                    patient.AnimalType,
                    patient.ClientId,          
                    patient.AnimalType.Species,
                    patient.AnimalType.Breed
                }, commandType: CommandType.Text) ;
            }
        }
    }
}
