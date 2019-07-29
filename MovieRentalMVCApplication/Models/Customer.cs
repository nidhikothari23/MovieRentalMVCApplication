using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalMVCApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Customer Name is Mandatory")]
        [StringLength(50)]
        [Display(Name="Customer Name")]
        public string CustName { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime Dob { get; set; }
      
        public bool IsSubscribedToNewsLater { get; set; }
        public MembershipType MembershipTypes { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}