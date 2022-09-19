using CommonBeneficiary.Application.DTOs.RelationTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Features.RelationTypes.Requests.Commands
{
    public class UpdateRelationTypeCommand:IRequest
    {
        public RelationTypeDto RelationTypeDto { get; set; }
    }
}
