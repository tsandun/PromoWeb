using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Rates
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public ApplicationUser Rate_To{ get; set; }
        public ApplicationUser Rate_From { get; set; }
        public string Comment{ get; set; }
    }
}