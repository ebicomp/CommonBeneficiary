using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CommonBeneficiary.Api.Controllers
{
    public class RelationTypeController : BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetRelationTypes()
        {
            var request = new GetRelationTypeListRequest();
            var result = await Mediator.Send(request);
            return HandleResponse(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRelationType(long id)
        {
            var request = new GetRelationTypeDetailRequest { Id = id };
            var result = await Mediator.Send(request);
            return HandleResponse(result);

        }
        [HttpPost]
        public async Task<IActionResult> CreateRelationType(RelationTypeDto relationTypeDto)
        {
            var command = new CreateRelationTypeCommand { RelationTypeDto = relationTypeDto };
            var result = await Mediator.Send(command);
            return HandleResponse(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRelationType(long id, RelationTypeDto relationTypeDto)
        {
            relationTypeDto.Id = id;
            var command = new UpdateRelationTypeCommand {  RelationTypeDto = relationTypeDto };
            var result = await Mediator.Send(command);
            return HandleResponse(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRelationType(long id)
        {
            var command = new DeleteRelationTypeCommand{ Id = id};
            var result = await Mediator.Send(command);
            return HandleResponse(result);
        }
    }
}
