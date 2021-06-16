using DataBridge.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace DataBridge.Infrastructure
{
    public class ConnectionFactory : ICustomConnectionFactory
    {
        private readonly string connectionString = @"Server=DESKTOP-MACHINE\SQLEXPRESS;Database=CompanyBaseData;User Id=SA;Password=yourpwd";
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
