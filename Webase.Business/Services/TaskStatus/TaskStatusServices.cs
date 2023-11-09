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
    
    public List<TaskStatusDto> RetrieveAll1()
    {
        var entities = Repository.SelectAll().ToList();
        var dtos = entities.Select(e => mapper.Map<TaskStatusDto>(e)).ToList();
        
        return dtos;
    }
    public TaskStatusDto RetrieveAll12(int id)
    {
        var entities = Repository.SelectByIdAsync(id);
        var dtos = mapper.Map<TaskStatusDto>(entities);
        
        return dtos;
    }

}