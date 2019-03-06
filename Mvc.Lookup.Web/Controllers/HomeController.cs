using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;

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


        [HttpGet]
        public JsonResult AllPeople(LookupFilter filter)
        {
            return Json(new PeopleLookup { Filter = filter }.GetData());
        }
    }
}
