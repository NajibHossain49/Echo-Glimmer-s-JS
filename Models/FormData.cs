using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Validation.Annotation;

namespace Validation.Models
{
    public class FormData
    {
        [Required(ErrorMessage = "Name is required !")]
        [NameValidation(ErrorMessage = "Only alphabets, hyphens (-), and spaces are allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required !")]
        [UserNameValidation(ErrorMessage = "Maximum 10 characters allowed with no spaces, only numbers and special characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "ID is required !")]
        [IdValidation(ErrorMessage = "Sign in with your organizational Id number.")]
        public string ID { get; set; }

        [Required(ErrorMessage = "Email is required !")]
        [EmailValidation(ErrorMessage = "Sign in with your organizational Email.")]
        [CompareIDWithEmail(ErrorMessage = "ID and Email format Portion do not match !")]
        public string Email { get; set; }
       
    }
}