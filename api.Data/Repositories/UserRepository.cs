using api.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Data.Repositories
{
    public class UserRepository : IUserRepository
    { 
        private PostgresSQLConfiguration _connectionString;
        public UserRepository(PostgresSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        
        // generando la conexion a la base de datos para el repository User
        protected NpgsqlConnection dbConnection()
        {
            Console.WriteLine("ENRTAAAAA 2 "+  _connectionString.ConnectionString);
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }
        public async Task<Users> getUserByEmail(string email)
        {
            var sql = @"SELECT * FROM users WHERE email = @email ";
            Console.WriteLine("SQL: "+sql);
            var db = dbConnection();
            return await db.QueryFirstOrDefaultAsync<Users>(sql, new {email = email});
        }
    }
}
