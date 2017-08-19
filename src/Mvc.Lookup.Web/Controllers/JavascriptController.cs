using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class JavascriptController : Controller
    {
        [HttpGet]
        public ViewResult Reload()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Browse()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Select()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Readonly()
        {
            return View();
        }

        [HttpGet]
        public ViewResult FilterChange()
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
