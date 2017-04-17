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
            Filter.Rows = 5;
            Title = "People";
            Url = "AllPeople";
            Filter.Sort = "Income";
            Filter.Order = LookupSortOrder.Desc;
        }

        public override IQueryable<Person> GetModels()
        {
            return PeopleRepository.Get();
        }

        public override void AddAutocomplete(Dictionary<String, String> row, Person model)
        {
            row[AcKey] = model.Name + " " + model.Surname;
        }
        public override void AddData(Dictionary<String, String> row, Person model)
        {
            base.AddData(row, model);

            if (model.IsWorking == true)
                row["IsWorking"] = "Person is employed";
            else if (model.IsWorking == false)
                row["IsWorking"] = "Person is unemployed";
            else
                row["IsWorking"] = "It's unknown is person is employed or not";
        }
    }
}
