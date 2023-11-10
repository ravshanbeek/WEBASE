using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class ProjectServices
    :GenericServices<
        int,
        Project,
        ProjectDto,
        ProjectForCreation,
        ProjectForModification,
        IProjectRepository>,
        IProjectServices
{
    public ProjectServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
    public async override ValueTask<ProjectDto> RetrieveByIdAsync(int id)
    {
        var employee = await Repository
            .SelectByIdWithDetailsAsync(x => x.Id == id, 
                new[] { "Priority" ,"Type"});
        return mapper.Map<ProjectDto>(employee);
    }

    public override IQueryable<ProjectDto> RetrieveAll()
    {
        var projects = Repository
            .SelectAll()
            .Include(x => x.Type)
            .Include(x =>x.Priority);
        
        var mappedProjects = projects.Select(x => mapper.Map<ProjectDto>(x));
        return mappedProjects;
    }
}