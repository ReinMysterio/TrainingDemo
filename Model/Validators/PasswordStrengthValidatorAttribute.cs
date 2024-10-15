using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model.Validators
{
    public class PasswordStrengthValidatorAttribute : ValidationAttribute
    {
        private readonly int _minLength;

        public PasswordStrengthValidatorAttribute(int minLength = 8)
        {
            _minLength = minLength;
            ErrorMessage = ErrorMessage ?? "Password must meet complexity requirements.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;

            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult("Password is required.");
            }

            if (password.Length < _minLength)
            {
                return new ValidationResult($"Password must be at least {_minLength} characters long.");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return new ValidationResult("Password must contain at least one uppercase letter.");
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                return new ValidationResult("Password must contain at least one lowercase letter.");
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                return new ValidationResult("Password must contain at least one digit.");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return new ValidationResult("Password must contain at least one special character.");
            }

            // If all checks pass, return success.
            return ValidationResult.Success;
        }
    }
}
