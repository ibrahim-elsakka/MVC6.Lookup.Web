using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using NonFactors.Mvc.Lookup.Web.Models;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class JavascriptController : Controller
    {
        [HttpGet]
        public ViewResult Api()
        {
            return View();
        }

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
        public ViewResult SelectFirst()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SelectSingle()
        {
            return View();
        }

        [HttpGet]
        public ViewResult FilterChange()
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
    }
}
