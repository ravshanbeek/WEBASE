using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

    public async override ValueTask<TaskDto> CreateAsync(TaskForCreation tmodel)
    {
        var entity = mapper.Map<Task>(tmodel);
        entity.Statusid = 1;
        var createdTask = await Repository.InsertAsync(entity);
        
        return mapper.Map<TaskDto>(createdTask);
    }

    public override IQueryable<TaskDto> RetrieveAll()
    {
        var tasks = Repository
            .SelectAll()
            .Include(x => x.Status)
            .Include(x => x.Employees);
        var mappedTasks = tasks.Select(x => mapper.Map<TaskDto>(x));
        return mappedTasks;
    }

    public async override ValueTask<TaskDto> RetrieveByIdAsync(int id)
    {
        var task = await Repository
            .SelectByIdWithDetailsAsync(x => x.Id == id,
                new[] { "Status", "Employees" });
        
        return mapper.Map<TaskDto>(task);
    }
}