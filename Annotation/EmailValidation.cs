using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Validation.Annotation
{

    public class EmailValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true; // Return true if value is null (considered as optional)
            }

            string inputValue = value.ToString();

            // Define the regular expression pattern for email validation
            string emailPattern = @"^[1-9][0-9]-[0-9]{5}-[1-3]@student\.aiub\.edu$";

            // Check if the input matches the pattern
            if (!Regex.IsMatch(inputValue, emailPattern))
            {
                return false;
            }

            return true;
        }
    }
}



