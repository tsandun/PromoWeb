using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    public class Category
    { 
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool Active_Status{ get; set; }
        public Category Parent_Id { get; set; }
    }
}