using AutoMapper;
using Webase.Business.DTOs.Task;
using Webase.Data.Repositories;
using Task = Webase.Data.Task;

namespace Webase.Business.Services;

public class TaskServices
    :GenericServices<int,
        Task,
        TaskDto,
        TaskForCreation,
        TaskForModification,
        ITaskRepository>,
        ITaskServices
{
    public TaskServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}