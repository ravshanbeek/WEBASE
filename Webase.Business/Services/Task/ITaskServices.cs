using Webase.Business.DTOs.Task;
using Webase.Data.Repositories;
using Task = Webase.Data.Task;

namespace Webase.Business.Services;

public interface ITaskServices 
    :IGenericServices<
        int,
        Task,
        TaskDto,
        TaskForCreation,
        TaskForModification,
        TaskRepository>
{
}