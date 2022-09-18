using CommonBeneficiary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Domain
{
    public class RelationType:BaseDomainEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
