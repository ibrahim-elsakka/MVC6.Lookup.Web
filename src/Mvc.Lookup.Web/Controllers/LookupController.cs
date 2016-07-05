using Microsoft.AspNetCore.Mvc;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class LookupController : Controller
    {
        [HttpGet]
        public ViewResult Title()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SourceUrl()
        {
            return View();
        }

        [HttpGet]
        public ViewResult HiddenData()
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
        public ViewResult DefaultRows()
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
