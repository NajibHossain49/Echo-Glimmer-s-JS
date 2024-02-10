using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Validation.Annotation
{

    public class IdValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false; // Return false if value is null (considered as optional)
            }

            string inputValue = value.ToString();

            // Define the regular expression pattern
            string pattern = @"^[1-9][1-9]-[0-9]{5}-[1-3]$";

            // Check if the input matches the pattern
            if (!Regex.IsMatch(inputValue, pattern))
            {
                return false;
            }

            return true;
        }
    }
}




