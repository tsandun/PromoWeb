using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Content{ get; set; }
        public ApplicationUser From{ get; set; }
        public ApplicationUser To { get; set; }
    }
}