using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.Core.Extenstions.Validations;
using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.DTOs.RelationTypes.Validators;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using CommonBeneficiary.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Handlers.Commands
{
    public class CreateRelationTypeCommandHandler : IRequestHandler<CreateRelationTypeCommand, BaseResponse<RelationType>>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public CreateRelationTypeCommandHandler(IRelationTypeRepository repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<RelationType>> Handle(CreateRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new RelationTypeDtoValidator();
            var validationResult = validator.Validate(request.RelationTypeDto);
            if (!validationResult.IsValid)
            {
                return BaseResponse<RelationType>.Failure("خطا در ساخت رابطه جدید", validationResult.GetErrorMessages());
            }
            var relationType = _mapper.Map<RelationType>(request.RelationTypeDto);
            var result = await _repository.Add(relationType);
            if (result == null) return BaseResponse<RelationType>.Success(errors: new List<string> { "خطا در ورود اطلاعات" }, value: relationType);
            return BaseResponse<RelationType>.Success("رابطه جدید ساخته شد", value: relationType);
        }
    }
}
