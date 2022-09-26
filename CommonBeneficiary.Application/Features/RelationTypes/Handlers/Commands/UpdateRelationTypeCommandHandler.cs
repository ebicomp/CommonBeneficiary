using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.Core.Extenstions.Validations;
using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Application.DTOs.RelationTypes.Validators;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using CommonBeneficiary.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Handlers.Commands
{
    public class UpdateRelationTypeCommandHandler : IRequestHandler<UpdateRelationTypeCommand , BaseResponse<Unit>>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public UpdateRelationTypeCommandHandler(IRelationTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<Unit>> Handle(UpdateRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var relationType = await _repository.Get(request.RelationTypeDto.Id);
            if (relationType == null) return BaseResponse<Unit>.Failure(errors: new List<string> { "رابطه با کد داده شده شناسایی نشد" });

            var validator = new RelationTypeDtoValidator();
            var validateResult = validator.Validate(request.RelationTypeDto);

            if (!validateResult.IsValid)
            {
                return BaseResponse<Unit>.Failure(errors: validateResult.GetErrorMessages());
            }

            _mapper.Map(request.RelationTypeDto, relationType);
            var result = await _repository.Update(relationType);
            if (result > 0) return BaseResponse<Unit>.Success(message:"به روزرسانی با موفقیت انجام شد");

            return BaseResponse<Unit>.Failure(errors: new List<string> { "خطا در به روزرسانی رابطه" });
        }
    }
}
