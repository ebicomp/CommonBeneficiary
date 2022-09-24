using CommonBeneficiary.Application.Core.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands
{
    public class DeleteRelationTypeCommand:IRequest<BaseResponse<Unit>>
    {
        public long Id { get; set; }
    }
}
