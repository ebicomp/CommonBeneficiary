using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Persistence.Repositories
{
    public class RelationTypeRepository : GenericRepository<RelationType>, IRelationTypeRepository
    {
        public RelationTypeRepository(CommonBeneficiaryDbContext context) : base(context)
        {
        }
    }
}
