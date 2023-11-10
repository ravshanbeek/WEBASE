using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs.Task;
using Webase.Business.Services;

namespace Webase.Api.Controllers
{
    [Route("Task/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskServices services;

        public TaskController(ITaskServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async ValueTask<ActionResult<TaskDto>> Post(TaskForCreation task)
        {
            var created = await services.CreateAsync(task);

            return Created("", created);
        }

        [HttpGet]
        public async ValueTask<ActionResult<TaskDto>> GetAll()
        {
            var tasks = services.RetrieveAll();

            return Ok(tasks);
        }

        [HttpGet("id")]
        public async ValueTask<ActionResult<TaskDto>> GetById(int id)
        {
            var task = await services.RetrieveByIdAsync(id);

            return Ok(task);
        }

        [HttpPut]
        public async ValueTask<ActionResult<TaskDto>> Update(TaskForModification task)
        {
            var modifiedTask = await services.ModifyAsync(task);

            return Ok(modifiedTask);
        }
    }
}
