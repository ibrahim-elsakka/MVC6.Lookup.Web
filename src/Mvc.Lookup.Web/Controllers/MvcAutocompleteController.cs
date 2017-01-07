using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class MvcAutocompleteController : Controller
    {
        public JsonResult Default(LookupFilter filter, Int32? autocompleteAge)
        {
            filter.AdditionalFilters["Age"] = autocompleteAge;

            return Json(new PeopleAutocomplete() { Filter = filter }.GetData());
        }
    }
}
