using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalMVCApplication.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Membership_Name { get; set; }
        public short SignupFee { get; set; }
        public byte DuratiopnInMonths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}