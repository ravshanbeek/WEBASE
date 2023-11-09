using Webase.Business.DTOs;
using Webase.Business.DTOs.Task;
using Webase.Data.Repositories;
using TaskStatus = Webase.Data.TaskStatus;

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
    List<TaskStatusDto> RetrieveAll1(); 
    TaskStatusDto RetrieveAll12(int id);

}