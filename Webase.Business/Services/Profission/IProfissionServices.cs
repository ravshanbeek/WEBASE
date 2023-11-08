using Webase.Business.DTOs;
using Webase.Business.DTOs.Profission;
using Webase.Data;
using Webase.Data.Repositories;
namespace Webase.Business.Services;

public interface IProfissionServices 
    : IGenericServices<
        int,
        Profission,
        ProfissionDto,
        ProfessionForCreation,
        ProfissionDto,
        ProfissionRepository>
{
    
}