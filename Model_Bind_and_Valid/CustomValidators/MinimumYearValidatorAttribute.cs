﻿using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.CustomValidators
{
    public class MinimumYearValidatorAttribute:ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public string DefaultErrorMessage { get; set; } = "Minimum year allowed is {0}";

        #region Constructor
        public MinimumYearValidatorAttribute(){}
        public MinimumYearValidatorAttribute(int minimuYear)
        {
            MinimumYear = minimuYear;
        }
        #endregion

        #region IsValid
        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value != null)
            {
                DateTime date = (DateTime)value;
                //if (date.Year >= 2000)
                if (date.Year >= MinimumYear)
                {
                    //return new ValidationResult("Minimum year allowed is 2000");

                    //____ PreDefined ErrorMessage ___
                    //return new ValidationResult(ErrorMessage);

                    //____ PreDefined ErrorMessage + CurrentValue ___
                    //return new ValidationResult(string.Format(ErrorMessage,MinimumYear));

                    //____ Set Default ErrorMessage ___
                    //??  null colisun operator
                    return new ValidationResult(string.Format(
                        ErrorMessage ?? DefaultErrorMessage,
                        MinimumYear
                        ));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
        #endregion
    }
}
