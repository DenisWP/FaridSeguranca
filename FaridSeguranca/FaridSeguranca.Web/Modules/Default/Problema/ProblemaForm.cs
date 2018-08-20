
namespace FaridSeguranca.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Problema")]
    [BasedOnRow(typeof(Entities.ProblemaRow), CheckNames = true)]
    public class ProblemaForm
    {
        public Int32 CriadoPor { get; set; }
        public String Relatado { get; set; }
        public Int32 RelatoId { get; set; }
        public Int32 LocalEmpresa { get; set; }
        public String Descricao { get; set; }
    }
}