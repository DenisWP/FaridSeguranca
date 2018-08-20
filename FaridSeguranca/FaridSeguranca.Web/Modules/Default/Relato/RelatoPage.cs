
namespace FaridSeguranca.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Relato"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RelatoRow))]
    public class RelatoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Relato/RelatoIndex.cshtml");
        }
    }
}