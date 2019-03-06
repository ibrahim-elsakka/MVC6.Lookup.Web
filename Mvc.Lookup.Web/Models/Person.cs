using Mvc.Lookup.Web.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace NonFactors.Mvc.Lookup.Web.Models
{
    public class Person
    {
        [LookupColumn(Hidden = true)]
        public Int32 Id { get; set; }

        [LookupColumn]
        [Display(ResourceType = typeof(Resources), Name = "Name")]
        public String Name { get; set; }

        [LookupColumn]
        [Display(ResourceType = typeof(Resources), Name = "Surname")]
        public String Surname { get; set; }

        [LookupColumn]
        [Display(ResourceType = typeof(Resources), Name = "Income")]
        public Int32? Income { get; set; }

        [LookupColumn(Format = "{0:d}")]
        [Display(ResourceType = typeof(Resources), Name = "Birthday")]
        public DateTime Birthday { get; set; }

        public Boolean? IsWorking { get; set; }
    }
}
