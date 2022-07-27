using System.ComponentModel.DataAnnotations;

namespace WebApiAutores2Udemy.Validation
{
    public class PrimeraLetraMAttribute: ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var primerLetra = value.ToString()[0].ToString();
            if (primerLetra != primerLetra.ToUpper())
            {
                return new ValidationResult("la primera letra debe ser mayuscula");
            }

            return ValidationResult.Success;
        }
    }
}
