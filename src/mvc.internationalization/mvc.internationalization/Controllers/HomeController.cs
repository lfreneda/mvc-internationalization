using System.Web.Mvc;

namespace mvc.internationalization.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = mvc.internationalization.resources.Resources.HelloMessage;
            return View();
        }
    }
}
