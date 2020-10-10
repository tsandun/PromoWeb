using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Province
    {
        public int Id{ get; set; }
        public int Name{ get; set; }
        public District District { get; set; }
    }
}