using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using System;
using System.Globalization;
using System.Threading;

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
        public ViewResult Multi()
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
        public ViewResult Autocomplete()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Configuration()
        {
            return View();
        }


        [HttpGet]
        public JsonResult AllPeople(LookupFilter filter, Int32? autocompleteIncome, Int32? lookupIncome)
        {
            filter.AdditionalFilters["Income"] = autocompleteIncome ?? lookupIncome;

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }

        [HttpGet]
        public JsonResult WorkingPeople(LookupFilter filter)
        {
            filter.AdditionalFilters["IsWorking"] = true;

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }

        [HttpGet]
        public JsonResult LocalizedPeople(LookupFilter filter)
        {
            CultureInfo.CurrentCulture = new CultureInfo("de");
            CultureInfo.CurrentUICulture = new CultureInfo("de");

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }

        [HttpGet]
        public JsonResult AllPeopleWithIncome(LookupFilter filter, Int32? autocompleteIncome)
        {
            filter.AdditionalFilters["Income"] = autocompleteIncome;

            return Json(new PeopleLookup { Filter = filter }.GetData());
        }
    }
}
