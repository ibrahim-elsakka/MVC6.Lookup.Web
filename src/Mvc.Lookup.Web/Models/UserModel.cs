using System;
using System.ComponentModel.DataAnnotations;

namespace NonFactors.Mvc.Lookup.Web.Models
{
    public class PersonModel
    {
        [LookupColumn(Hidden = true)]
        public Int32 Id { get; set; }

        [LookupColumn]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [LookupColumn]
        [Display(Name = "Surname")]
        public String Surname { get; set; }

        [LookupColumn]
        [Display(Name = "Age")]
        public Int32 Age { get; set; }

        [LookupColumn(Format = "{0:d}")]
        [Display(Name = "Birthday", ShortName = "Birth")]
        public DateTime Birthday { get; set; }

        public Boolean? IsWorking { get; set; }
    }
}
