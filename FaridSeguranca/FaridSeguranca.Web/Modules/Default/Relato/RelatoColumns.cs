
namespace FaridSeguranca.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Relato")]
    [BasedOnRow(typeof(Entities.RelatoRow), CheckNames = true)]
    public class RelatoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        
        [EditLink, DisplayName("Tipo do Relato"), AlignRight]
        public String TipoRelato { get; set; }
    }
}