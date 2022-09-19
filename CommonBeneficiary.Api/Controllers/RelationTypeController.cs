using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommonBeneficiary.Api.Controllers
{
    public class RelationTypeController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<RelationTypeDto>>> GetRelationTypes()
        {
            var request = new GetRelationTypeListRequest();
            var result = await Mediator.Send(request);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RelationTypeDto>> GetRelationType(long id)
        {
            var request = new GetRelationTypeDetailRequest { Id = id };
            var result = await Mediator.Send(request);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRelationType(RelationTypeDto relationTypeDto)
        {
            var command = new CreateRelationTypeCommand { RelationTypeDto = relationTypeDto };
            var result = await Mediator.Send(command);
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRelationType(long id, RelationTypeDto relationTypeDto)
        {
            relationTypeDto.Id = id;
            var command = new UpdateRelationTypeCommand {  RelationTypeDto = relationTypeDto };
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRelationType(long id)
        {
            var command = new DeleteRelationTypeCommand{ Id = id};
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
