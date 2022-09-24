using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.Core.Responses;
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
    public class GetRelationTypeListRequestHandler : IRequestHandler<GetRelationTypeListRequest, BaseResponse<List<RelationTypeDto>>>
    {
        private readonly IRelationTypeRepository _relationTypeRepository;
        private readonly IMapper _mapper;

        public GetRelationTypeListRequestHandler(IRelationTypeRepository relationTypeRepository, IMapper mapper)
        {
            _relationTypeRepository = relationTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<RelationTypeDto>>> Handle(GetRelationTypeListRequest request, CancellationToken cancellationToken)
        {
            var result = await _relationTypeRepository.GetAll();
            var relationTypes = _mapper.Map<List<RelationTypeDto>>(result);
            return BaseResponse<List<RelationTypeDto>>.Success(value: relationTypes);
        }
    }
}
