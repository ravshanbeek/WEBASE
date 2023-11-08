using AutoMapper;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class EmployeeServices 
    : GenericServices<int,
            Employee,
            EmployeeDto,
            EmployeeForCreation,
            EmployeeForModification,
            IEmployeeRepository>,
     IEmployeeServices
{
    public EmployeeServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }
}