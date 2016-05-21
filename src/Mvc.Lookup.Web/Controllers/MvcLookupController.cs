using Microsoft.AspNetCore.Mvc;
using NonFactors.Mvc.Lookup.Web.Lookups;
using System;

namespace NonFactors.Mvc.Lookup.Web.Controllers
{
    public class MvcLookupController : Controller
    {
        public JsonResult Default(LookupFilter filter, Int32? lookupAge)
        {
            filter.AdditionalFilters.Add("Age", lookupAge);

            return GetData(new PeopleLookup(), filter);
        }

        private JsonResult GetData(MvcLookup lookup, LookupFilter filter)
        {
            lookup.CurrentFilter = filter;

            return Json(lookup.GetData());
        }
    }
}
