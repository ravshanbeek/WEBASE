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
    [Route("projectType/[action]")]
    [ApiController]
    public class ProjectTypeController : ControllerBase
    {
        private IProjectTypeServices services;

        public ProjectTypeController(IProjectTypeServices services)
        {
            this.services = services;
        }
        
        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
        {
            var projectTypes =  services.RetrieveAll().ToList();
            return Ok(projectTypes);
        }

        [HttpPost]
        public async ValueTask<ActionResult> Post(ProjectTypeForCreation status)
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
