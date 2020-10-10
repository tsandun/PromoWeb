using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Delivery
    {
        public int Id{ get; set; }
        public decimal Charge{ get; set; }
        public decimal Start_latitude{ get; set; }
        public decimal Start_longtitide{ get; set; }
        public decimal End_latitude { get; set; }
        public decimal End_longtitide { get; set; }
        public ApplicationUser ApplicationUser{ get; set; }
        public AdvertisementModel Advertisement { get; set; }

    }
}