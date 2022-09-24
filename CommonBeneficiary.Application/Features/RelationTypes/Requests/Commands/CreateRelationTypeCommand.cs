using CommonBeneficiary.Application.Core.Responses;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands
{
    public class CreateRelationTypeCommand:IRequest<BaseResponse<RelationType>>
    {
        public RelationTypeDto RelationTypeDto { get; set; }
    }
}
