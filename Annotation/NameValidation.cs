using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Validation.Annotation
{
    public class NameValidation :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false; // Return false if value is null (considered as optional)
            }

            string inputValue = value.ToString();

            foreach (char c in inputValue)
            {
                if (!char.IsLetter(c) && c != '-' && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
