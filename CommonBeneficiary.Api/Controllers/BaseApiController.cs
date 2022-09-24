using CommonBeneficiary.Application.Core.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CommonBeneficiary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController: ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResponse<T>(BaseResponse<T> result)
        {
            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);

            if(result.IsSuccess && result.Message != "")
                return Ok(result.Message);

            if (result.IsSuccess && result.Value == null)
                return NotFound();

            return BadRequest(result.Errors);
        }


    }
}
