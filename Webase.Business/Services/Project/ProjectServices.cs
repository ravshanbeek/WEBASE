using AutoMapper;
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
        ProjectDto,
        IProjectRepository>,
        IProjectServices
{
    public ProjectServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}