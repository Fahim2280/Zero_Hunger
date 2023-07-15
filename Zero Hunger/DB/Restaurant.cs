using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.DB
{
    public class Restaurant
    {
        [Required]
        public int RestaurantID { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string RestaurantDescription { get; set; }
        [Required]
        public string RestaurantCont { get; set; }
        [Required]
        public string RestaurantEmail { get; set; }
        [Required]
        public string RestaurantOwner { get; set; }
        [Required]
        public string RestaurantAddress { get; set; }

        public virtual ICollection<EmployeeAssingn> EmployeeAssingns { get; set; }
    }
}