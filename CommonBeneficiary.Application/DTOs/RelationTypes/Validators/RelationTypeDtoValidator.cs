using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.DTOs.RelationTypes.Validators
{
    internal class RelationTypeDtoValidator:AbstractValidator<RelationTypeDto>
    {
        public RelationTypeDtoValidator()
        {
            RuleFor(q => q.Code).NotEmpty().WithMessage("ثبت مقدار کد رابطه الزامی است");
            RuleFor(q => q.Name).NotEmpty().WithMessage("ثبت مقدار عنوان رابطه الزامی است");
        }
    }
}
