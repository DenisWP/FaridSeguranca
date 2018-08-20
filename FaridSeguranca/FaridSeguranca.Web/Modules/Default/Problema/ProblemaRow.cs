
namespace FaridSeguranca.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Problema]")]
    [DisplayName("Problema"), InstanceName("Problema")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProblemaRow : Row, IIdRow, INameRow
    {

        [DisplayName("Código do Problema"), PrimaryKey]
        public Int32? ProblemaId
        {
            get { return Fields.ProblemaId[this]; }
            set { Fields.ProblemaId[this] = value; }
        }

        [DisplayName("Criado Por"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jCriadoPor"), TextualField("CriadoPorUsername")]
        public Int32? CriadoPor
        {
            get { return Fields.CriadoPor[this]; }
            set { Fields.CriadoPor[this] = value; }
        }

        [DisplayName("Relatado"), Size(255), NotNull, QuickSearch]
        public String Relatado
        {
            get { return Fields.Relatado[this]; }
            set { Fields.Relatado[this] = value; }
        }

        [DisplayName("Relato"), ForeignKey("[dbo].[Relato]", "Id"), LeftJoin("jRelato"), TextualField("RelatoTipoRelato")]
        public Int32? RelatoId
        {
            get { return Fields.RelatoId[this]; }
            set { Fields.RelatoId[this] = value; }
        }

        [DisplayName("Local da Empresa"), ForeignKey("[dbo].[Empresa]", "Id"), LeftJoin("jLocalEmpresa"), TextualField("LocalEmpresaNome")]
        public Int32? LocalEmpresa
        {
            get { return Fields.LocalEmpresa[this]; }
            set { Fields.LocalEmpresa[this] = value; }
        }

        [DisplayName("Descrição"), Size(500), NotNull]
        public String Descricao
        {
            get { return Fields.Descricao[this]; }
            set { Fields.Descricao[this] = value; }
        }



        [DisplayName("Criado Por Username"), Expression("jCriadoPor.[Username]")]
        public String CriadoPorUsername
        {
            get { return Fields.CriadoPorUsername[this]; }
            set { Fields.CriadoPorUsername[this] = value; }
        }

        [DisplayName("Criado Por Display Name"), Expression("jCriadoPor.[DisplayName]")]
        public String CriadoPorDisplayName
        {
            get { return Fields.CriadoPorDisplayName[this]; }
            set { Fields.CriadoPorDisplayName[this] = value; }
        }

        [DisplayName("Criado Por Email"), Expression("jCriadoPor.[Email]")]
        public String CriadoPorEmail
        {
            get { return Fields.CriadoPorEmail[this]; }
            set { Fields.CriadoPorEmail[this] = value; }
        }

        [DisplayName("Criado Por Source"), Expression("jCriadoPor.[Source]")]
        public String CriadoPorSource
        {
            get { return Fields.CriadoPorSource[this]; }
            set { Fields.CriadoPorSource[this] = value; }
        }

        [DisplayName("Criado Por Password Hash"), Expression("jCriadoPor.[PasswordHash]")]
        public String CriadoPorPasswordHash
        {
            get { return Fields.CriadoPorPasswordHash[this]; }
            set { Fields.CriadoPorPasswordHash[this] = value; }
        }

        [DisplayName("Criado Por Password Salt"), Expression("jCriadoPor.[PasswordSalt]")]
        public String CriadoPorPasswordSalt
        {
            get { return Fields.CriadoPorPasswordSalt[this]; }
            set { Fields.CriadoPorPasswordSalt[this] = value; }
        }

        [DisplayName("Criado Por Last Directory Update"), Expression("jCriadoPor.[LastDirectoryUpdate]")]
        public DateTime? CriadoPorLastDirectoryUpdate
        {
            get { return Fields.CriadoPorLastDirectoryUpdate[this]; }
            set { Fields.CriadoPorLastDirectoryUpdate[this] = value; }
        }

        [DisplayName("Criado Por User Image"), Expression("jCriadoPor.[UserImage]")]
        public String CriadoPorUserImage
        {
            get { return Fields.CriadoPorUserImage[this]; }
            set { Fields.CriadoPorUserImage[this] = value; }
        }

        [DisplayName("Criado Por Insert Date"), Expression("jCriadoPor.[InsertDate]")]
        public DateTime? CriadoPorInsertDate
        {
            get { return Fields.CriadoPorInsertDate[this]; }
            set { Fields.CriadoPorInsertDate[this] = value; }
        }

        [DisplayName("Criado Por Insert User Id"), Expression("jCriadoPor.[InsertUserId]")]
        public Int32? CriadoPorInsertUserId
        {
            get { return Fields.CriadoPorInsertUserId[this]; }
            set { Fields.CriadoPorInsertUserId[this] = value; }
        }

        [DisplayName("Criado Por Update Date"), Expression("jCriadoPor.[UpdateDate]")]
        public DateTime? CriadoPorUpdateDate
        {
            get { return Fields.CriadoPorUpdateDate[this]; }
            set { Fields.CriadoPorUpdateDate[this] = value; }
        }

        [DisplayName("Criado Por Update User Id"), Expression("jCriadoPor.[UpdateUserId]")]
        public Int32? CriadoPorUpdateUserId
        {
            get { return Fields.CriadoPorUpdateUserId[this]; }
            set { Fields.CriadoPorUpdateUserId[this] = value; }
        }

        [DisplayName("Criado Por Is Active"), Expression("jCriadoPor.[IsActive]")]
        public Int16? CriadoPorIsActive
        {
            get { return Fields.CriadoPorIsActive[this]; }
            set { Fields.CriadoPorIsActive[this] = value; }
        }



        [DisplayName("Relato Tipo Relato"), Expression("jRelato.[TipoRelato]")]
        public String RelatoTipoRelato
        {
            get { return Fields.RelatoTipoRelato[this]; }
            set { Fields.RelatoTipoRelato[this] = value; }
        }



        [DisplayName("Local Empresa Nome"), Expression("jLocalEmpresa.[Nome]")]
        public String LocalEmpresaNome
        {
            get { return Fields.LocalEmpresaNome[this]; }
            set { Fields.LocalEmpresaNome[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProblemaId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Relatado; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProblemaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProblemaId;

            public Int32Field CriadoPor;

            public StringField Relatado;

            public Int32Field RelatoId;

            public Int32Field LocalEmpresa;

            public StringField Descricao;



            public StringField CriadoPorUsername;

            public StringField CriadoPorDisplayName;

            public StringField CriadoPorEmail;

            public StringField CriadoPorSource;

            public StringField CriadoPorPasswordHash;

            public StringField CriadoPorPasswordSalt;

            public DateTimeField CriadoPorLastDirectoryUpdate;

            public StringField CriadoPorUserImage;

            public DateTimeField CriadoPorInsertDate;

            public Int32Field CriadoPorInsertUserId;

            public DateTimeField CriadoPorUpdateDate;

            public Int32Field CriadoPorUpdateUserId;

            public Int16Field CriadoPorIsActive;



            public StringField RelatoTipoRelato;



            public StringField LocalEmpresaNome;


		}
    }
}
