using Webase.Business.DTOs;
using Webase.Business.DTOs.Task;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface ITaskStatusServices 
    :IGenericServices <
        int,
        TaskStatus,
        TaskStatusDto,
        TaskStatusForCreation,
        TaskStatusDto,
        TaskStatusRepository>
{
}