using FluentMigrator;
using System;

namespace FaridSeguranca.Migrations.DefaultDB
{

    [Migration(20180820170000)]
    public class DefaultDB_20180820170000: AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Empresa")
                .AddColumn("Codigo").AsInt32().NotNullable();

            Alter.Table("Relato")
                .AddColumn("Codigo").AsInt32().NotNullable();                  
        }
    }
}