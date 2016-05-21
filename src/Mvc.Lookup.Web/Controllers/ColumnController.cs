using Microsoft.AspNetCore.Mvc;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class ColumnController : Controller
    {
        [HttpGet]
        public ViewResult Header()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CssClass()
        {
            return View();
        }
    }
}
