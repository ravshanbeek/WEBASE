using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface IPriorityStatusServices 
    :IGenericServices<
        int,
        PriorityStatus,
        PriorityStatusDto,
        PriorityStatusForCreation,
        PriorityStatusDto,
        PriorityStatusRepository>
{
}