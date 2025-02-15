using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs;
using Webase.Business.Services;

namespace Webase.Api.Controllers
{
    [Route("taskStatus/[action]")]
    [ApiController]
    public class TaskStatusController : ControllerBase
    {
        private readonly ITaskStatusServices services;

        public TaskStatusController(ITaskStatusServices taskServices)
        {
            this.services = taskServices;
        }
        
        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
        {
            var taskStatuses =  services.RetrieveAll().ToList();
            return Ok(taskStatuses);
        }

        [HttpPost]
        public async ValueTask<ActionResult> Post(TaskStatusForCreation status)
        {
            var createdStatus = await services.CreateAsync(status);
            return Created("", createdStatus);
        }

        [HttpDelete]
        public async ValueTask<ActionResult> DeleteAsync(int id)
        {
            var deletedStatus = await services.RemoveByIdAsync(id);

            return Ok(deletedStatus);
        }
    }
}
