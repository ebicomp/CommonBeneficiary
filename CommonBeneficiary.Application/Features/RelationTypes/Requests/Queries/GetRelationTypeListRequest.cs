using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Requests.Queries
{
    public class GetRelationTypeListRequest:IRequest<BaseResponse<List<RelationTypeDto>>>
    {
    }
}
