using ClickCity.Domain.Entities;
using ClickCity.Domain.Repository;
using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Infra.Repository.Postgres.Repository
{
    internal class WorkplaceRepository(DbSession session) : IWorkplaceRepository
    {
        private readonly DbSession _session = session;

        public async Task CreateAsync(Workplace entity, CancellationToken cancellationToken = default)
        {
            const string query = @"
                INSERT INTO public.workplaces VALUES (@Id, @Name, @Description);
            ";

            using (var command = _session.Connection.CreateCommand())
            {
                command.CommandText = query;

                command.Parameters.AddWithValue("@Id", entity.Id);
                command.Parameters.AddWithValue("@Name", entity.Name);
                command.Parameters.AddWithValue("@Description", entity.Description ?? (object)DBNull.Value);

                await command.ExecuteNonQueryAsync();
            }
        }

        public Task DeleteAsync(Workplace entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Workplace?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Workplace entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}