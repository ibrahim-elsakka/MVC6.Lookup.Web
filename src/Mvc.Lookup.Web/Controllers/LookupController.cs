using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using NonFactors.Mvc.Lookup.Web.Models;
using System;
using System.Globalization;
using System.Threading;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class LookupController : Controller
    {
        [HttpGet]
        public ViewResult Name()
        {
            return View();
        }

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
        public ViewResult Placeholder()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Localization()
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
        public ViewResult SortOptions()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ColumnPosition()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ColumnHeader()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PagingOptions()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Id()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Label()
        {
            return View();
        }


        [HttpGet]
        public JsonResult AllPeople(LookupFilter filter, Int32? autocompleteIncome, Int32? lookupIncome, Boolean? isWorking)
        {
            filter.AdditionalFilters[nameof(Person.Income)] = autocompleteIncome ?? lookupIncome;
            filter.AdditionalFilters[nameof(Person.IsWorking)] = isWorking;

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }

        [HttpGet]
        public JsonResult LocalizedPeople(LookupFilter filter)
        {
            CultureInfo.CurrentCulture = new CultureInfo("de");
            CultureInfo.CurrentUICulture = new CultureInfo("de");

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }
    }
}
