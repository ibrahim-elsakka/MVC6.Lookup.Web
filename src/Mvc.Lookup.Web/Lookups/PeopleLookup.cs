using NonFactors.Mvc.Lookup.Web.Context;
using NonFactors.Mvc.Lookup.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NonFactors.Mvc.Lookup.Web.Lookups
{
    public class PeopleLookup : GenericLookup<PersonModel>
    {
        public PeopleLookup()
        {
            DialogTitle = "People";
            DefaultRecordsPerPage = 5;
            DefaultSortColumn = "Surname";
            LookupUrl = "/MvcLookup/Default";
            AdditionalFilters.Add("LookupAge");
        }

        protected override IQueryable<PersonModel> GetModels()
        {
            return PeopleRepository.GetPeople();
        }

        protected override void AddAdditionalData(Dictionary<String, String> row, PersonModel model)
        {
            row.Add("HiddenKey", "Hidden data for ID: " + model.Id);
        }

        protected override void AddAutocomplete(Dictionary<String, String> row, PersonModel model)
        {
            row.Add(AcKey, model.Name + " " + model.Surname);
        }
    }
}
