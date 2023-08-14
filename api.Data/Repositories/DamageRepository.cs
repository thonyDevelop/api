using api.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api.Data.Repositories
{
    public class DamageRepository : IDamageRepository
    {
        private PostgresSQLConfiguration _connectionString;
        public DamageRepository(PostgresSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<ResponseDamage> DamageRegister(Damage damage)
        {
            var sql = @"SELECT * FROM fnc_damage_register(('"+ JsonSerializer.Serialize(damage)+"')::jsonb) ";
            Console.WriteLine("SQL: " + sql);
            var db = dbConnection();
            return await db.QueryFirstOrDefaultAsync<ResponseDamage>(sql);
        }
    }
}
