﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.Models
{
    public class CustomValidationModel
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        [DisplayName("Person Name")]
        [StringLength(40,MinimumLength =3,ErrorMessage ="{0} should b/w {2} and {1}")]
        //{0} name ,  {1} maxLenght , {2} minLength  
        public string? PersonName { get; set; }

        //________________ CustomValidation _____________
    }
}