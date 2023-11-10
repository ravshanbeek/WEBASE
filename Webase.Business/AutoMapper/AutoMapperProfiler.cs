using System.Linq.Expressions;
using System.Security.Cryptography;
using AutoMapper;
using AutoMapper.Internal;
using Webase.Business.DTOs;
using Webase.Business.DTOs.Profission;
using Webase.Business.DTOs.Task;
using Webase.Data;
using Task = Webase.Data.Task;
using TaskStatus = Webase.Data.TaskStatus;

namespace Webase.Business.AutoMapper;

public class AutoMapperProfiler : Profile
{
    public AutoMapperProfiler()
    {
        CreateMap<Employee, EmployeeDto>()
            .ForMember(dest => dest.TelephoneNumber, opt => opt.MapFrom(src => src.Phonenumber))
            .ForMember(dest => dest.ProfissionName, opt => opt.MapFrom(src => src.Profission.Name));

        CreateMap<EmployeeForCreation, Employee>()
            .ForMember(dest => dest.Phonenumber, opt => opt.MapFrom(src => src.TelephoneNumber));

        CreateMap<EmployeeForModification, Employee>()
            .ForMember(dec=> dec.Phonenumber,opt=>opt.MapFrom(src=>src.TelephoneNumber));


        CreateMap<Organization, OrganizationDto>();

        CreateMap<Project, ProjectDto>()
            .ForMember(des => des.ProjectType, opt => opt.MapFrom(src => src.Type.Typename))
            .ForMember(des => des.ProjectPriority, opt => opt.MapFrom(src => src.Priority.Statusname))
            .ReverseMap();

        CreateMap<ProjectForCreation, Project>()
            .ForMember(des=>des.Priorityid, opt=>opt.MapFrom(src=>src.ProjectPriorityId))
            .ForMember(des=>des.Typeid, opt=>opt.MapFrom(src=>src.ProjectTypeId));

        CreateMap<ProjectForModification, Project>()
            .ForMember(des => des.Priorityid, opt => opt.MapFrom(src => src.ProjectPriorityId))
            .ForMember(des => des.Typeid, opt => opt.MapFrom(src => src.ProjectTypeId));

        CreateMap<Task, TaskDto>()
            .ForMember(des => des.TaskStatus, opt => opt.MapFrom(src => src.Status.Statusname));
            // .ForMember(des => des.Employees,
            //     opt => opt.MapFrom(src => src.Employees.Select(emp => new { emp.Firstname, emp.Lastname })));

        CreateMap<TaskForCreation, Task>();

        CreateMap<TaskForModification, Task>();

        CreateMap<TaskStatus, TaskStatusDto>();

        CreateMap<TaskStatusForCreation, TaskStatus>();

        CreateMap<PriorityStatus, PriorityStatusDto>();

        CreateMap<PriorityStatusForCreation, PriorityStatus>();

        CreateMap<ProjectType, ProjectTypeDto>();

        CreateMap<ProjectTypeForCreation, ProjectType>();

        CreateMap<Profission, ProfissionDto>();
        CreateMap<ProfessionForCreation, Profission>();

    }
}