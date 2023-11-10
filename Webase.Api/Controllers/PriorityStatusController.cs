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
    [Route("priorityStatus/[action]")]
    [ApiController]
    public class PriorityStatusController : ControllerBase
    {
        private IPriorityStatusServices services;

        public PriorityStatusController(IPriorityStatusServices services)
        {
            this.services = services;
        }
        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
        {
            var taskStatuses =  services.RetrieveAll().ToList();
            return Ok(taskStatuses);
        }

        [HttpPost]
        public async ValueTask<ActionResult> Post(PriorityStatusForCreation status)
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
