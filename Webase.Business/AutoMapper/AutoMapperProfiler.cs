using AutoMapper;
using Webase.Business.DTOs;
using Webase.Business.DTOs.Profission;
using Webase.Data;

namespace Webase.Business.AutoMapper;

public class AutoMapperProfiler : Profile
{
    public AutoMapperProfiler()
    {
        CreateMap<Employee, EmployeeDto>()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.firstname, opt => opt.MapFrom(src => src.Firstname))
            .ForMember(dest => dest.lastName, opt => opt.MapFrom(src => src.Lastname))
            .ForMember(dest => dest.telephoneNumber, opt => opt.MapFrom(src => src.Phonenumber))
            .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.profissionName, opt => opt.MapFrom(src => src.Profission.Name));

        CreateMap<EmployeeForCreation, Employee>()
            .ForMember(src => src.Firstname, opt => opt.MapFrom(src => src.firstname))
            .ForMember(src => src.Lastname, opt => opt.MapFrom(src => src.lastName))
            .ForMember(src => src.Email, opt => opt.MapFrom(src => src.email))
            .ForMember(src => src.Phonenumber, opt => opt.MapFrom(src => src.telephoneNumber))
            .ForMember(src => src.Profissionid, opt => opt.MapFrom(src => src.profissionId));
        
        CreateMap<EmployeeForModification, Employee>()
                    .ForMember(src => src.Id, opt => opt.MapFrom(src => src.id))
                    .ForMember(src => src.Firstname, opt => opt.MapFrom(src => src.firstname))
                    .ForMember(src => src.Lastname, opt => opt.MapFrom(src => src.lastName))
                    .ForMember(src => src.Email, opt => opt.MapFrom(src => src.email))
                    .ForMember(src => src.Phonenumber, opt => opt.MapFrom(src => src.telephoneNumber))
                    .ForMember(src => src.Profissionid, opt => opt.MapFrom(src => src.profissionId));

    }
}