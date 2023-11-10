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
    [Route("Project/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectServices services;
        
        public ProjectController(IProjectServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async ValueTask<ActionResult<ProjectDto>> Post(ProjectForCreation project)
        {
            var created = await services.CreateAsync(project);
            return Created("", created);
        }

        [HttpGet]
        public async ValueTask<ActionResult<ProjectDto>> GetAll()
        {
            var all = services.RetrieveAll();
            return Ok(all);
        }

        [HttpGet("id")]
        public async ValueTask<ActionResult<ProjectDto>> GetById(int id)
        {
            var project = await services.RetrieveByIdAsync(id);
            return Ok(project);
        }

        [HttpPut]
        public async ValueTask<ActionResult<ProjectDto>> Update(ProjectForModification project)
        {
            var updated = await services.ModifyAsync(project);
            return Ok(project);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<ProjectDto>> Delete(int id)
        {
            var deleted = await services.RemoveByIdAsync(id);
            return Ok(deleted);
        }
    }
}
