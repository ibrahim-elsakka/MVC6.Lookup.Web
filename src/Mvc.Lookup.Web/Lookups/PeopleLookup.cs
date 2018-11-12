using NonFactors.Mvc.Lookup.Web.Context;
using NonFactors.Mvc.Lookup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NonFactors.Mvc.Lookup.Web.Lookups
{
    public class PeopleLookup : MvcLookup<Person>
    {
        public override IQueryable<Person> GetModels()
        {
            return PeopleRepository.Get();
        }

        public override Dictionary<String, String> FormData(Person model)
        {
            Dictionary<String, String> data = base.FormData(model);
            data["Label"] = model.Name + " " + model.Surname;

            if (model.IsWorking == true)
                data["IsWorking"] = "Person is employed";
            else if (model.IsWorking == false)
                data["IsWorking"] = "Person is unemployed";
            else
                data["IsWorking"] = "Unknown if employed";

            return data;
        }
    }
}
