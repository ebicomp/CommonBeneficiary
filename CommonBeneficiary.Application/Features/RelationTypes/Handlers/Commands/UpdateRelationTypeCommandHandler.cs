using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.DTOs.RelationTypes;
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
    public class UpdateRelationTypeCommandHandler : IRequestHandler<UpdateRelationTypeCommand>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public UpdateRelationTypeCommandHandler(IRelationTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var relationType = await _repository.Get(request.RelationTypeDto.Id);
            //relationType = _mapper.Map<RelationType>(request.RelationTypeDto);
            _mapper.Map(request.RelationTypeDto, relationType);
            await _repository.Update(relationType);
            return Unit.Value;
        }
    }
}
