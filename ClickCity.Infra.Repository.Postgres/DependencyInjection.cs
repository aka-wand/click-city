using ClickCity.Application.Common.Repositories;
using ClickCity.Domain.Repository;
using ClickCity.Infra.Repository.Postgres.Repository;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace ClickCity.Infra.Repository.Postgres
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentException("TODO");

            services.AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddPostgres()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(Assembly.GetExecutingAssembly()).For.All())
                .AddLogging(lb => lb.AddFluentMigratorConsole());

            services.AddScoped(s => new DbSession(connectionString));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // Repositories
            services.AddTransient<IWorkplaceRepository, WorkplaceRepository>();

            return services;
        }

        public static IServiceProvider RunMigrations(this IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                runner.MigrateUp();

                return provider;
            }
        }
    }
}