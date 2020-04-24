using AutoMapper;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Utilities
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Make, MakeDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name)).ReverseMap();

            CreateMap<Model, ModelDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.makeId, opt => opt.MapFrom(src => src.MakeID)).ReverseMap();

            CreateMap<Trim, TrimDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.modelId, opt => opt.MapFrom(src => src.ModelID)).ReverseMap();

        }
    }
}
