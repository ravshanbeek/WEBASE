using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

    public async override ValueTask<EmployeeDto> RetrieveByIdAsync(int id)
    {
        var employee = await Repository.SelectByIdWithDetailsAsync(x => x.Id == id, new[] { "Profission" });
        return mapper.Map<EmployeeDto>(employee);
    }

    public override IQueryable<EmployeeDto> RetrieveAll()
    {
        var employees = Repository.SelectAll().Include(x => x.Profission);
        var mappedEmployees = employees.Select(x => mapper.Map<EmployeeDto>(x));
        return mappedEmployees;
    }
}