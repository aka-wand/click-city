using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Infra.Repository.Postgres.Migrations
{
    [Migration(202408231236)]
    public class AddUuidExtension : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Execute.Sql("CREATE EXTENSION IF NOT EXISTS \"uuid-ossp\";");
        }
    }
}