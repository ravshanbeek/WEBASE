using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs;
using Webase.Business.Services;
using Task = Webase.Data.Task;

namespace Webase.Api.Controllers
{
    [Route("api/employees")]
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
            return Created("", createdEmployee);
        }
    }
}
