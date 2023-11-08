using AutoMapper;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class OrganizationServices 
    : GenericServices<
        int,
        Organization,
        OrganizationDto,
        OrganizationForCreation,
        EmployeeForModification,
        IOrganizationRepository>,
        IOrganizationServices
{
    public OrganizationServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}