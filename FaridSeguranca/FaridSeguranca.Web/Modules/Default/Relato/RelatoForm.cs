
namespace FaridSeguranca.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Relato")]
    [BasedOnRow(typeof(Entities.RelatoRow), CheckNames = true)]
    public class RelatoForm
    {
        public String TipoRelato { get; set; }
    }
}