using AutoMapper;
using Webase.Business.DTOs.Profission;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class ProfissionServices 
    :GenericServices<
        int,
        Profission,
        ProfissionDto,
        ProfessionForCreation,
        ProfissionDto,
        IProfissionRepository>,
        IProfissionServices
{
    public ProfissionServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}