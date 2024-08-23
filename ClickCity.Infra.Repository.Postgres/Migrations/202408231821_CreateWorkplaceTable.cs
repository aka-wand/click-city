using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Infra.Repository.Postgres.Migrations
{
    [Migration(202408231821)]
    public class CreateWorkplaceTable : Migration
    {
        public override void Down()
        {
            Delete.Table("workplaces");
        }

        public override void Up()
        {
            Create.Table("workplaces")
                .WithColumn("id").AsCustom("uuid").PrimaryKey()
                .WithColumn("name").AsString().Unique().NotNullable()
                .WithColumn("description").AsString().Nullable();
        }
    }
}