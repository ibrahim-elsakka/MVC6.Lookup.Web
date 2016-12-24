using NonFactors.Mvc.Lookup.Web.Context;
using NonFactors.Mvc.Lookup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NonFactors.Mvc.Lookup.Web.Lookups
{
    public class PeopleLookup : MvcLookup<PersonModel>
    {
        public PeopleLookup()
        {
            Filter.Rows = 5;
            Title = "People";
            Url = "/MvcLookup/Default";
            Filter.SortColumn = "Surname";
            AdditionalFilters.Add("LookupAge");
        }

        public override IQueryable<PersonModel> GetModels()
        {
            return PeopleRepository.GetPeople();
        }

        public override void AddData(Dictionary<String, String> row, PersonModel model)
        {
            base.AddData(row, model);

            if (model.IsWorking == true)
                row.Add("IsWorking", "Person is employed");
            else if (model.IsWorking == false)
                row.Add("IsWorking", "Person is unemployed");
            else
                row.Add("IsWorking", "It's unknown is person is employed or not");
        }

        public override void AddAutocomplete(Dictionary<String, String> row, PersonModel model)
        {
            row.Add(AcKey, model.Name + " " + model.Surname);
        }
    }
}
