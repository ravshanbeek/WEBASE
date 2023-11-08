using AutoMapper;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class ProjectTypeServices 
    :GenericServices<
        int,
        ProjectType,
        ProjectDto,
        ProjectTypeForCreation,
        ProjectTypeDto,
        IProjectTypeRepository>,
        IProjectTypeServices
{
    public ProjectTypeServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}