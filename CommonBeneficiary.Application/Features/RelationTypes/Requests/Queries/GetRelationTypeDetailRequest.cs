using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries
{
    public class GetRelationTypeDetailRequest:IRequest<BaseResponse<RelationTypeDto>>
    {
        public long Id { get; set; }
    }
}
