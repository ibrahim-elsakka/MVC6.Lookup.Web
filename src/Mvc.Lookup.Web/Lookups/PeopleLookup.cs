using NonFactors.Mvc.Lookup.Web.Context;
using NonFactors.Mvc.Lookup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NonFactors.Mvc.Lookup.Web.Lookups
{
    public class PeopleLookup : MvcLookup<Person>
    {
        public PeopleLookup()
        {
            Title = "People";
            Url = "AllPeople";
            Filter.Sort = "Income";
            Filter.Order = LookupSortOrder.Desc;
            GetLabel = (model) => model.Name + " " + model.Surname;
        }

        public override IQueryable<Person> GetModels()
        {
            return PeopleRepository.Get();
        }

        public override Dictionary<String, String> FormData(Person model)
        {
            Dictionary<String, String> data = base.FormData(model);

            if (model.IsWorking == true)
                data["IsWorking"] = "Person is employed";
            else if (model.IsWorking == false)
                data["IsWorking"] = "Person is unemployed";
            else
                data["IsWorking"] = "It's unknown is person is employed or not";

            return data;
        }
    }
}
