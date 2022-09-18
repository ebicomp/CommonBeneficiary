using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommonBeneficiary.Api.Controllers
{
    public class RelationTypeController:BaseApiController
    {
        private readonly IMediator _mediator;

        public RelationTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<RelationTypeDto>>> GetRelationTypes()
        {
            var request = new GetRelationTypeListRequest();
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
