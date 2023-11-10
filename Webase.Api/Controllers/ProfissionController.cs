using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs.Profission;
using Webase.Business.Services;

namespace Webase.Api.Controllers
{
    [Route("profission/[action]")]
    [ApiController]
    public class ProfissionController : ControllerBase
    {
        private IProfissionServices services;

        public ProfissionController(IProfissionServices services)
        {
            this.services = services;
        }
        
        
        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
        {
            var profission =  services.RetrieveAll().ToList();
            return Ok(profission);
        }

        [HttpPost]
        public async ValueTask<ActionResult> Post(ProfessionForCreation profession)
        {
            var createdProfission = await services.CreateAsync(profession);
            return Created("", createdProfission);
        }

        [HttpDelete]
        public async ValueTask<ActionResult> DeleteAsync(int id)
        {
            var deletedProfission = await services.RemoveByIdAsync(id);

            return Ok(deletedProfission);
        }
    }
}
