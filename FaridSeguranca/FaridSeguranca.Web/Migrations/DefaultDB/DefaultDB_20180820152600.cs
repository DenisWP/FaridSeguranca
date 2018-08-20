using FluentMigrator;
using System;

namespace FaridSeguranca.Migrations.DefaultDB
{

    [Migration(20180820152600)]
    public class DefaultDB_20180820152600: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Empresa")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Nome").AsString(255).NotNullable();

           Create.Table("Relato")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("TipoRelato").AsString(255).NotNullable();

            Create.Table("Problema")
                .WithColumn("ProblemaId").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("CriadoPor").AsInt32().Nullable()
                    .ForeignKey("FK_RelatoCriadoPor_Users", "Users", "UserId")
                .WithColumn("Relatado").AsString(255).NotNullable()
                .WithColumn("RelatoId").AsInt32().Nullable()
                    .ForeignKey("FK_ProblemaRelato_RelatoId", "Relato", "Id")
                .WithColumn("LocalEmpresa").AsInt32().Nullable()
                    .ForeignKey("FK_LocalEmpresa_EmpresaId", "Empresa", "Id")
                .WithColumn("Descricao").AsString(500).NotNullable();           
        }
    }
}