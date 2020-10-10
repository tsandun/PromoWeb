using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{

    public class Language
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public bool Status{ get; set; }
    }
}