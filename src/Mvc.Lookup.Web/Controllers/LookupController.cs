using Microsoft.AspNet.Mvc;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class LookupController : Controller
    {
        [HttpGet]
        public ViewResult SourceUrl()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DialogTitle()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AdditionalData()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AdditionalFilters()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultSortOrder()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultSortColumn()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultRecordsPerPage()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Autocomplete()
        {
            return View();
        }
    }
}
