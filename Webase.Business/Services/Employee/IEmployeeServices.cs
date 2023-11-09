using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public interface IEmployeeServices 
    :IGenericServices<
        int,
        Employee,
        EmployeeDto,
        EmployeeForCreation,
        EmployeeForModification,
        EmployeeRepository>
{
}