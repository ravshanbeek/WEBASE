using System.Reflection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Webase.Business.AutoMapper;
using Webase.Business.Services;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbContexts(
        this IServiceCollection service,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgresSql");

        service.AddDbContextPool<PostgresContext>(option =>
            {
                option.UseNpgsql(connectionString);
            }
        );

        return service;
    }

    public static IServiceCollection AddRepositories(
        this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IOrganizationRepository, OrganizationRepository>();
        services.AddScoped<IPriorityStatusRepository, PriorityStatusRepository>();
        services.AddScoped<IProfissionRepository, ProfissionRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IProjectTypeRepository, ProjectTypeRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<ITaskStatusRepository, TaskStatusRepository>();

        return services;
    }

    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddScoped<IOrganizationServices, OrganizationServices>();
        services.AddScoped<IEmployeeServices, EmployeeServices>();
        services.AddScoped<IPriorityStatusServices, PriorityStatusServices>();
        services.AddScoped<IProfissionServices, ProfissionServices>();
        services.AddScoped<IProjectServices, ProjectServices>();
        services.AddScoped<IProjectTypeServices, ProjectTypeServices>();
        services.AddScoped<ITaskServices, TaskServices>();
        services.AddScoped<ITaskStatusServices, TaskStatusServices>();
        
        
            
        return services;
    }    
    


}