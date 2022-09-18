using AutoMapper;
using CommonBeneficiary.Application.DTOs.RelationTypes;
using CommonBeneficiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Profiles
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RelationType, RelationTypeDto>().ReverseMap();
        }
    }

}
