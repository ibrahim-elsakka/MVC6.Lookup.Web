using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class MvcAutocompleteController : Controller
    {
        public JsonResult Default(LookupFilter filter, Int32? autocompleteAge)
        {
            filter.AdditionalFilters.Add("Age", autocompleteAge);

            return GetData(new PeopleAutocomplete(), filter);
        }

        private JsonResult GetData(MvcLookup lookup, LookupFilter filter)
        {
            lookup.Filter = filter;

            return Json(lookup.GetData());
        }
    }
}
