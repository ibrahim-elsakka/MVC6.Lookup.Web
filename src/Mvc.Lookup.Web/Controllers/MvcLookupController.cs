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

            return Json(new PeopleLookup() { Filter = filter }.GetData());
        }
    }
}
