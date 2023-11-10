using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs;
using Webase.Business.Services;
using Webase.Data;
using Task = Webase.Data.Task;

namespace Webase.Api.Controllers;

[Route("employees/[action]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeServices employeeServices;
    public EmployeeController(IEmployeeServices employeeServices)
    {
        this.employeeServices = employeeServices;
    }

    [HttpPost]
    public async ValueTask<ActionResult<EmployeeDto>> PostEmployeeAsync(EmployeeForCreation employee)
    {
        var createdEmployee = await employeeServices.CreateAsync(employee);
        return Created("",createdEmployee);
    }

    [HttpGet]
    public async ValueTask<ActionResult<EmployeeDto>> RetrieveEmployees()
    {
        var employees = employeeServices.RetrieveAll();
        return Ok(employees);
    }
    
    [HttpGet("id")]
    public async ValueTask<ActionResult<EmployeeDto>> RetrieveEmployeeBtId(int id)
    {
        var employees = await employeeServices.RetrieveByIdAsync(id);
        return Ok(employees);
    }

    [HttpPut]
    public async ValueTask<ActionResult<EmployeeDto>> UpdateEmployeeAsync(EmployeeForModification employee)
    {
        var modifiedEmployee = await employeeServices.ModifyAsync(employee);

        return Ok(modifiedEmployee);
    }

    [HttpDelete]
    public async ValueTask<ActionResult<EmployeeDto>> DeleteEmployeeAsync(int id)
    {
        var removedEmployee = await employeeServices.RemoveByIdAsync(id);
        return Ok(removedEmployee);
    }
}

