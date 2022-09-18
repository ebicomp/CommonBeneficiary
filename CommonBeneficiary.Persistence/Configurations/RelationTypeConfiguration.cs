using CommonBeneficiary.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Persistence.Configurations
{
    public class RelationTypeConfiguration : IEntityTypeConfiguration<RelationType>
    {
        public void Configure(EntityTypeBuilder<RelationType> builder)
        {
            builder.HasData(
                new RelationType
            {
                Id = 1,
                Name = "همسر",
                Code = "001"
            },
                new RelationType
                {
                    Id = 2,
                    Name = "فرزند",
                    Code = "002"
                }
            );
        }
    }
}
