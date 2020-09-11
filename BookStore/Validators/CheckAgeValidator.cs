using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace BookStore.Validators
{
    public class CheckAgeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;

            if ((date.Year - 18) > 0)
                return new ValidationResult("Somente mairoes de 18 anos");

            return ValidationResult.Success;
        }
    }
}