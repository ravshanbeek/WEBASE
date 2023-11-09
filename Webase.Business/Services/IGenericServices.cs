using System.Linq.Expressions;
using Task = Webase.Data.Task;

namespace Webase.Business.Services;

public interface IGenericServices<TId,TEntity,TDto,TCreateDto,TModifyDto,TRepository>
{
    ValueTask<TDto> CreateAsync(TCreateDto model);
    IQueryable<TDto> RetrieveAll();
    ValueTask<TDto> RetrieveByIdAsync(TId id);
    ValueTask<TDto> ModifyAsync(TModifyDto model);
    ValueTask<TDto> RemoveByIdAsync(TId id);
}