using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Webase.Business.AutoMapper;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public abstract class GenericServices<TId,TEntity,TDto,TCreateDto,TModifyDto,TRepository> 
    :IGenericServices<TId,TEntity,TDto,TCreateDto,TModifyDto,TRepository>
    where TId : struct
    where TDto : class 
    where TCreateDto : class 
    where TRepository : class , IGenericRepository<TEntity,TId>
{
    protected TRepository Repository { get; }
    protected IServiceProvider _serviceProvider;
    protected IMapper mapper;
    
    public GenericServices(IMapper mapper, IServiceProvider ServiceProvider)
    {
        _serviceProvider = ServiceProvider;
        this.mapper = mapper;
        Repository = _serviceProvider.GetRequiredService<TRepository>();
    }

    public async virtual ValueTask<TDto> CreateAsync(TCreateDto tmodel)
    {
        var entity = mapper.Map<TEntity>(tmodel);
        var result = await Repository.InsertAsync(entity);
        return mapper.Map<TDto>(result);
    }

    public virtual IQueryable<TDto> RetrieveAll()
    {
        var entities = Repository.SelectAll().ToList();
        var dtos = entities.Select(e => mapper.Map<TDto>(e)).ToList();
        return dtos.AsQueryable();
    }

    public async virtual ValueTask<TDto> RetrieveByIdAsync(TId id)
    {
        var entity = await Repository.SelectByIdAsync(id);
        return mapper.Map<TDto>(entity);
    }

    public async virtual ValueTask<TDto> ModifyAsync(TModifyDto model)
    {
        var entity = mapper.Map<TEntity>(model);
        var storedEntity = await Repository.UpdateAsync(entity);
        return mapper.Map<TDto>(storedEntity);
    }

    public async ValueTask<TDto> RemoveByIdAsync(TId id)
    {
        var entity = await Repository.SelectByIdAsync(id);
        var deletedEntity = await Repository.DeleteAsync(entity);
        return mapper.Map<TDto>(deletedEntity);
    }
}