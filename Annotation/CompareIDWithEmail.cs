using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Validation.Models;

namespace Validation.Annotation
{
    public class CompareIDWithEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (FormData)validationContext.ObjectInstance;

            // Extract the prefix of the email
            string emailPrefix = user.Email?.Split('@')[0];

            // Compare the entire ID with the email prefix
            if (user.ID != emailPrefix)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}



