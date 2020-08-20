using AutoMapper;
using AutoMapperExample.Customizations;
using AutoMapperExample.Models;
using AutoMapperExample.ViewModels;
using System;

namespace AutoMapperExample.AutoMapper
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<string, DateTime>().ConvertUsing<DateTimeTypeConverter>();
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.HasSecondaryAddress, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.Address.Street2)))
                .ForMember(dest => dest.Bmi, opt => opt.MapFrom<BmiValueResolver>())
                .IncludeMembers(u => u.Address, u => u.AdditionalInfo);
            CreateMap<Address, UserViewModel>(MemberList.None);
            CreateMap<AdditionalInfo, UserViewModel>(MemberList.None);
        }
    }
}
