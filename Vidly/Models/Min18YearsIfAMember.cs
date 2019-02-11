using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;
            
            if(customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            
            if(customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");

            int age = customer.Birthdate.Value.Year;

            return age >= 18 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
}