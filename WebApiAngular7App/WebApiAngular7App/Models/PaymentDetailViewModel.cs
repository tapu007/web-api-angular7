using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAngular7App.Models
{
    public class PaymentDetailViewModel
    {
        public int PaymentDetailViewModelID { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string CardOwnerName { get; set; }
        [Display(Name ="Card Number")]
        [Required(ErrorMessage = "Please Enter Card Number")]
        [StringLength(10)]
        public string CardNumber { get; set; }
        [Display(Name = "Expiration Date")]
        [Required(ErrorMessage = "Please Enter Expiration Date")]     
        public string ExpirationDate { get; set; }
        [Required(ErrorMessage = "Please Enter Cvv")]
        [StringLength(5)]
        public string CVV { get; set; }

    }
}
