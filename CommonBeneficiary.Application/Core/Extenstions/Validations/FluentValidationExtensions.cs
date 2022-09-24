using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Core.Extenstions.Validations
{
    public static class FluentValidationExtensions
    {
        public static List<string> GetErrorMessages(this ValidationResult validationResult)
        {
            return validationResult.Errors.Select(q => q.ErrorMessage).ToList();
        }
    }
}
