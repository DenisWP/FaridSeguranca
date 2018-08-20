
namespace FaridSeguranca.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Problema")]
    [BasedOnRow(typeof(Entities.ProblemaRow), CheckNames = true)]
    public class ProblemaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProblemaId { get; set; }

        [EditLink, DisplayName("Nome do Colaborador")]
        public String CriadoPorUsername { get; set; }

        [EditLink, DisplayName("Relatado"), AlignRight]
        public String Relatado { get; set; }

        [EditLink, DisplayName("Tipo de Relato")]
        public String RelatoTipoRelato { get; set; }

        [EditLink, DisplayName("Local da Ocorrência"), AlignRight]
        public String LocalEmpresaNome { get; set; }

        [EditLink, DisplayName("Descrição"), AlignRight]
        public String Descricao { get; set; }
    }
}