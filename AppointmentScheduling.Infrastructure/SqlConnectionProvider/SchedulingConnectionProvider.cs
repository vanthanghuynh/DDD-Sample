namespace AppointmentScheduling.Infrastructure.SqlConnectionProvider
{
    public class SchedulingConnectionProvider : SqlConnectionProvider
    {
        public SchedulingConnectionProvider(string connectionString) : base(connectionString) { }
    }
}
