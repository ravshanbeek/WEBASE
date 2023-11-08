using AutoMapper;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class PriorityStatusServices 
    : GenericServices<
        int,
        PriorityStatus,
        PriorityStatusDto,
        PriorityStatusForCreation,
        PriorityStatusDto,
        IPriorityStatusRepository>,
        IPriorityStatusServices
{
    public PriorityStatusServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}