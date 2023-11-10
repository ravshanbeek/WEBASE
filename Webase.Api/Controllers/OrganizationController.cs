using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webase.Business.DTOs;
using Webase.Business.Services;

namespace Webase.Api.Controllers
{
    [Route("organization/[action]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationServices organizationServices;

        public OrganizationController(IOrganizationServices organizationServices)
        {
            this.organizationServices = organizationServices;
        }

        [HttpPost]
        public async ValueTask<ActionResult<OrganizationDto>> PostOrganizationAsync(OrganizationForCreation organization)
        {
            var addedOrganization = await organizationServices.CreateAsync(organization);
            return Ok(addedOrganization);
        }

        [HttpGet]
        public async ValueTask<ActionResult<OrganizationDto>> RetrieveOrganizations()
        {
            var organizations = organizationServices.RetrieveAll();
            return Ok(organizations);
        }

        [HttpGet("id:int")]
        public async ValueTask<ActionResult<OrganizationDto>> RetrieveOrganizationById(int id)
        {
            var organization = await organizationServices.RetrieveByIdAsync(id);
            return Ok(organization);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<OrganizationDto>> DeleteOrganizationById(int id)
        {
            var deletedOrganization = await organizationServices.RemoveByIdAsync(id);
            return Ok(deletedOrganization);
        }
    }
}
