using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Address
    {
        public int Id{ get; set; }
        public Province Province { get; set; }
        public District District { get; set; }
        public City City { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }

    }
}