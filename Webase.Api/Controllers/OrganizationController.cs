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
    [Route("[action]/organization")]
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
        

    }
}
