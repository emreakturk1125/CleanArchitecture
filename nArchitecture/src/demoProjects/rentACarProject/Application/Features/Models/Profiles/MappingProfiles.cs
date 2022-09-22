using Application.Features.Models.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model,ModelListDto>().ReverseMap();   
            CreateMap<IPaginate<Model>,ModelListDto>().ReverseMap();
        }
    }
}
