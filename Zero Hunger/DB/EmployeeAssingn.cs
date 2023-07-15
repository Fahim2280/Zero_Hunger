using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zero_Hunger.DB
{
    public class EmployeeAssingn
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [Required]
        [ForeignKey("Restaurant")]
        public int RestaurantID { get; set; }
        [Required]
        public string Status { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}