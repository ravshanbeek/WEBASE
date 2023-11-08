using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface IProjectServices 
    :IGenericServices<
        int,
        Project,
        ProjectDto,
        ProjectForCreation,
        ProjectDto,
        ProjectRepository>
{
    
}