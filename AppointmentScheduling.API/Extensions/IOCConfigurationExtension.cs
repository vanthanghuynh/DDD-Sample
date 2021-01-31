using AppointmentScheduling.Core.Contracts;
using AppointmentScheduling.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentScheduling.API.Extensions
{
    public static class IOCConfigurationExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            services.AddTransient<IAppointmentTypeRepository, AppointmentTypeRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IScheduleRepository, ScheduleRepository>();

            return services;
        }
    }
}
