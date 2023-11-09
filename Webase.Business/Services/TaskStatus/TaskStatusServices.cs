using AutoMapper;
using Webase.Business.DTOs;
using Webase.Business.DTOs.Task;
using Webase.Data.Repositories;


namespace Webase.Business.Services;

public class TaskStatusServices 
    : GenericServices<
        int,
        Webase.Data.TaskStatus,
        TaskStatusDto,
        TaskStatusForCreation,
        TaskStatusDto,
        ITaskStatusRepository>,
        ITaskStatusServices
{
    private IMapper mapper;
    public TaskStatusServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
        this.mapper = mapper;
    }
}