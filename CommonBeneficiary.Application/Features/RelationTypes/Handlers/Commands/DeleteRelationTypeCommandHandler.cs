using AutoMapper;
using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Handlers.Commands
{
    public class DeleteRelationTypeCommandHandler : IRequestHandler<DeleteRelationTypeCommand>
    {
        private readonly IRelationTypeRepository _repository;
        private readonly IMapper _mapper;

        public DeleteRelationTypeCommandHandler(IRelationTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteRelationTypeCommand request, CancellationToken cancellationToken)
        {
            var relationType = await _repository.Get(request.Id);
            await _repository.Delete(relationType);
            return Unit.Value;
        }
    }
}
