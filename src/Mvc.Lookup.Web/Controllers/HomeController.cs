using Microsoft.AspNet.Mvc;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Installation()
        {
            return View();
        }
    }
}
