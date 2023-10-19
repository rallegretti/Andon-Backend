using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace Andon.Backend.Data
{
    public class AndonDBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AndonDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
