
namespace FaridSeguranca.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Empresa")]
    [BasedOnRow(typeof(Entities.EmpresaRow), CheckNames = true)]
    public class EmpresaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }

        [EditLink, DisplayName("Nome da Empresa"), AlignRight]
        public String Nome { get; set; }
    }
}