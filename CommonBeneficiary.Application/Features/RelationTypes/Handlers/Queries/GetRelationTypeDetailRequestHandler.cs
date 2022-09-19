using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Handlers.Queries
{
    public class GetRelationTypeDetailRequestHandler : IRequestHandler<GetRelationTypeDetailRequest, RelationTypeDto>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public GetRelationTypeDetailRequestHandler(IRelationTypeRepository repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<RelationTypeDto> Handle(GetRelationTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var relationType = await _repository.Get(request.Id);
            return _mapper.Map<RelationTypeDto>(relationType);
        }
    }
}
