using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Handlers.Commands
{
    public class DeleteRelationTypeCommandHandler : IRequestHandler<DeleteRelationTypeCommand, BaseResponse<Unit>>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public DeleteRelationTypeCommandHandler(IRelationTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<Unit>> Handle(DeleteRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var relationType = await _repository.Get(request.Id);
            if(relationType == null)
                return BaseResponse<Unit>.Failure(errors: new List<string> { "رابطه با کد داده شده یافت نشد" });

            var result = await _repository.Delete(relationType);
            if (result > 0)
                return BaseResponse<Unit>.Success();
            else
                return BaseResponse<Unit>.Failure(errors: new List<string> { "خطا در حذف رابطه" });


        }
    }
}
