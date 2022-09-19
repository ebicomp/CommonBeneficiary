using CommonBeneficiary.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.DTOs.RelationTypes
{
    public class RelationTypeDto:BaseDto
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
