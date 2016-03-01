using Microsoft.AspNet.Mvc;
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

        private JsonResult GetData(AbstractLookup lookup, LookupFilter filter)
        {
            lookup.CurrentFilter = filter;

            return Json(lookup.GetData());
        }
    }
}
