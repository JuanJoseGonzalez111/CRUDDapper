using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Datos
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public DbConnection GetDbConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("NorthwindConnectionString"));
        }
    }

}
