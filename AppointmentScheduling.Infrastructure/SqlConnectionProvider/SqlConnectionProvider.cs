using System.Data.SqlClient;

namespace AppointmentScheduling.Infrastructure.SqlConnectionProvider
{
    public abstract class SqlConnectionProvider
    {
        public string ConnectionString { get; }

        protected SqlConnectionProvider(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
           return new SqlConnection(this.ConnectionString);
        }
    }
}
