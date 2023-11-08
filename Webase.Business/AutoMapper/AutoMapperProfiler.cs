using AutoMapper;
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
        
        
        CreateMap<Organization, OrganizationDto>()
            .ForMember(des => des.inn, opt => opt.MapFrom(src => src.Inn))
            .ForMember(des => des.accounter, opt => opt.MapFrom(src => src.Accounter))
            .ForMember(des => des.address, opt => opt.MapFrom(src => src.Address))
            .ForMember(des => des.director, opt => opt.MapFrom(src => src.Director))
            .ForMember(des => des.okedid, opt => opt.MapFrom(src => src.Okedid))
            .ForMember(des => des.name, opt => opt.MapFrom(src => src.Name));

        CreateMap<Project, ProjectDto>()
            .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(des => des.name, opt => opt.MapFrom(src => src.Name))
            .ForMember(des => des.deadline, opt => opt.MapFrom(src => src.Deadline))
            .ForMember(des => des.organizationid, opt => opt.MapFrom(src => src.Organizationid))
            .ForMember(des => des.projectType, opt => opt.MapFrom(src => src.Type.Typename))
            .ForMember(des => des.projectPriority, opt => opt.MapFrom(src => src.Priority.Statusname));
        
        CreateMap<ProjectForCreation, Project>()
            .ForMember(des => des.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(des => des.Deadline, opt => opt.MapFrom(src => src.deadline))
            .ForMember(des => des.Organizationid, opt => opt.MapFrom(src => src.organizationid))
            .ForMember(des => des.Priorityid, opt => opt.MapFrom(src => src.projectPriority))
            .ForMember(des => des.Typeid, opt => opt.MapFrom(src => src.projectType));

        CreateMap<Task, TaskDto>()
            .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(des => des.name, opt => opt.MapFrom(src => src.Name))
            .ForMember(des => des.TaskStatus, opt => opt.MapFrom(src => src.Status.Statusname))
            .ForMember(des => des.startDate, opt => opt.MapFrom(src => src.Startdate))
            .ForMember(des => des.endDate, opt => opt.MapFrom(src => src.Enddate))
            .ForMember(des => des.completionDate, opt => opt.MapFrom(src => src.Completiondate))
            .ForMember(des => des.employees,
                opt => opt.MapFrom(src => src.Employees.Select(emp => new { emp.Firstname, emp.Lastname })));

        CreateMap<TaskForCreation, Task>()
            .ForMember(des => des.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(des => des.Startdate, opt => opt.MapFrom(src => src.startDate))
            .ForMember(des => des.Enddate, opt => opt.MapFrom(src => src.endDate))
            .ForMember(des => des.Projectid, opt => opt.MapFrom(src => src.projectId));

        CreateMap<TaskForModification, Task>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(des => des.Statusid, opt => opt.MapFrom(src => src.statusId))
            .ForMember(des => des.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(des => des.Startdate, opt => opt.MapFrom(src => src.startDate))
            .ForMember(des => des.Enddate, opt => opt.MapFrom(src => src.endDate))
            .ForMember(des => des.Completiondate, opt => opt.MapFrom(src => src.completionDate))
            .ForMember(des => des.Projectid, opt => opt.MapFrom(src => src.projectId));

        CreateMap<TaskStatus, TaskStatusDto>()
            .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(des => des.statusName, opt => opt.MapFrom(src => src.Statusname));

        CreateMap<TaskStatusForCreation, TaskStatus>()
            .ForMember(des => des.Statusname, opt => opt.MapFrom(src => src.statusName));
        
        CreateMap<PriorityStatus, PriorityStatusDto>()
            .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(des => des.statusName, opt => opt.MapFrom(src => src.Statusname));

        CreateMap<PriorityStatusForCreation, PriorityStatus>()
            .ForMember(des => des.Statusname, opt => opt.MapFrom(src => src.statusName));
        
        CreateMap<ProjectType, ProjectTypeDto>()
            .ForMember(des => des.id, opt => opt.MapFrom(src => src.Id))
            .ForMember(des => des.typeName, opt => opt.MapFrom(src => src.Typename));

        CreateMap<ProjectTypeForCreation, ProjectType>()
            .ForMember(des => des.Typename, opt => opt.MapFrom(src => src.typeName));
        
    }
}