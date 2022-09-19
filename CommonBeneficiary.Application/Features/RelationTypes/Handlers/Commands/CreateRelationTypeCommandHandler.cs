using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
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
    public class CreateRelationTypeCommandHandler : IRequestHandler<CreateRelationTypeCommand>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public CreateRelationTypeCommandHandler(IRelationTypeRepository repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var relationType = _mapper.Map<RelationType>(request.RelationTypeDto);
            await _repository.Add(relationType);
            return Unit.Value;
        }
    }
}
