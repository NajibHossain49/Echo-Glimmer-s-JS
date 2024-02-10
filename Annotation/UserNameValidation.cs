using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Annotation
{

    public class UserNameValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false; // Return false if value is null (considered as optional)
            }

            string inputValue = value.ToString();

            // Check if input length is within the allowed limit
            if (inputValue.Length > 10)
            {
                return false;
            }

            foreach (char c in inputValue)
            {
                // Check if character is not a number or special character
                if (!char.IsDigit(c) && !char.IsPunctuation(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}





