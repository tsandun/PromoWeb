using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public City City { get; set; }
    }
}