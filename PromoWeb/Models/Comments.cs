using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public string Content{ get; set; }
        public ApplicationUser ApplicationUser{ get; set; }

        public AdvertisementModel Advertisement{ get; set; }
    }
}