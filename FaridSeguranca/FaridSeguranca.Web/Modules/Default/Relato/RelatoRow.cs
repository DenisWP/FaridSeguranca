
namespace FaridSeguranca.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Relato]")]
    [DisplayName("Relato"), InstanceName("Relato")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RelatoRow : Row, IIdRow, INameRow
    {

        [DisplayName("Código do Relato"), PrimaryKey]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Tipo de Relato"), Size(255), NotNull, QuickSearch]
        public String TipoRelato
        {
            get { return Fields.TipoRelato[this]; }
            set { Fields.TipoRelato[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TipoRelato; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RelatoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field Id;

            public StringField TipoRelato;


		}
    }
}
