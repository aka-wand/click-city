using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Infra.Repository.Postgres
{
    public sealed class DbSession : IDisposable
    {
        public NpgsqlConnection Connection { get; }
        public IDbTransaction? Transaction { get; set; }

        public DbSession(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}