using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface IProjectTypeServices
    :IGenericServices<
        int,
        ProjectType,
        ProjectDto,
        ProjectTypeForCreation,
        ProjectTypeDto,
        ProjectTypeRepository>
{
    
}