
namespace FaridSeguranca.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Problema"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProblemaRow))]
    public class ProblemaController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Problema/ProblemaIndex.cshtml");
        }
    }
}