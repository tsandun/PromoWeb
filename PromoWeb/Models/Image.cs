using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Image_1 { get; set; }
        public string Image_2 { get; set; }
        public string Image_3 { get; set; }
        public AdvertisementModel Advertisement { get; set; }
    }
}