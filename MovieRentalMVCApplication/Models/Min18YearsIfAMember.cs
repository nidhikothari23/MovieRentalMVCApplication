using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalMVCApplication.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if(customer.MembershipTypeId==0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Dob == null)
                return new ValidationResult("Birthdate is Required");

            var age = DateTime.Today.Year - customer.Dob.Year;
            return (age >= 18) ? ValidationResult.Success
                : new ValidationResult("Should be greater than 18 years to avail membership");
        }
    }
}