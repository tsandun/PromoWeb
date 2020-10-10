using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PromoWeb.Models
{
    [Table("Advertisement")]
    public class AdvertisementModel
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime Update_at { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime Expire_at { get; set; }
        public bool Negotiable { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public bool Active_Status { get; set; }
        public string Contact_Name{ get; set; }
        public int Contact_Number { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Language Language { get; set; }
        public Category Category{ get; set; }
        public Address Address { get; set; }

    }
}