using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Please enter your First name!")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last name!")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your Address!")]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }
      
        public string Address2 { get; set; }
        [Required(ErrorMessage ="Please enter your City!")]
        public string City { get; set; }
   
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your ZipCode")]
        [StringLength(7, MinimumLength = 5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number!")]
        [StringLength(12, MinimumLength = 7)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
