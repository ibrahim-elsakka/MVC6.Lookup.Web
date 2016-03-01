using System;
using System.ComponentModel.DataAnnotations;

namespace NonFactors.Mvc.Lookup.Web.Models
{
    public class AccountModel
    {
        public String Id { get; set; }

        [Display(Name = "Login name")]
        public String LoginName { get; set; }
    }
}