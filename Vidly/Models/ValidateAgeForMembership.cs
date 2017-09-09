using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ValidateAgeForMembership : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.UNKNOWN
                || customer.MembershipTypeId == MembershipType.PAY_AS_YOU_GO)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthday is required.");

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("You must be at least 18 to join.");
        }
    }
}