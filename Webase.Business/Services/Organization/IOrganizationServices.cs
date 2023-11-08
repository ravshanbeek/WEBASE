using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface IOrganizationServices 
    : IGenericServices<
            int,
            Organization,
            OrganizationDto,
            OrganizationForCreation,
            EmployeeForModification,
            OrganizationRepository>
{
}