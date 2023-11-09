using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.Services;

namespace Webase.Api.Controllers
{
    [Route("TaskStatus/[action]")]
    [ApiController]
    public class TaskStatusController : ControllerBase
    {
        private readonly ITaskStatusServices taskServices;

        public TaskStatusController(ITaskStatusServices taskServices)
        {
            this.taskServices = taskServices;
        }
        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
        {
            var taskStatuses =  taskServices.RetrieveAll().ToList();
            return Ok(taskStatuses);
        }
    }
}
