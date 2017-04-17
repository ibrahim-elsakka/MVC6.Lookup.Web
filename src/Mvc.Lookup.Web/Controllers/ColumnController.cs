using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class ColumnController : Controller
    {
        [HttpGet]
        public ViewResult Key()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Header()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Position()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CssClass()
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
