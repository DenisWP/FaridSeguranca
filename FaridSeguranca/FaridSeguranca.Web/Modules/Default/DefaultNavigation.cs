using Serenity.Navigation;
using MyPages = FaridSeguranca.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Empresa", typeof(MyPages.EmpresaController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Problema", typeof(MyPages.ProblemaController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Relato", typeof(MyPages.RelatoController), icon: null)]