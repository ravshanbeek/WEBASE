using System.Net;
using System.Text.Json;
using AutoMapper;
using Webase.Business.DTOs;
using Webase.Data;
using Webase.Data.Repositories;

namespace Webase.Business.Services;

public class OrganizationServices 
    : GenericServices<
        int,
        Organization,
        OrganizationDto,
        OrganizationForCreation,
        EmployeeForModification,
        IOrganizationRepository>,
        IOrganizationServices
{
    public OrganizationServices(IMapper mapper,IServiceProvider provider) : base(mapper,provider)
    {
    }

    public async override ValueTask<OrganizationDto> CreateAsync(OrganizationForCreation tmodel)
    {
        string apiUrl = $"https://billing-api.edu.uz/Contractor/GetByInn/{tmodel.Inn}";
        string token = $@"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhZG1pbiIsInJvbGUiOiIxIiwiZXhwIjoxNjk5NjE3MDc0LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUwMDEiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjUwMDEifQ.OByBNs5Gtn3YfdwLT98Sf0muHaXTrOWgnT6YjMdrBGg";
        using HttpClient client = new HttpClient();
        
        client.DefaultRequestHeaders.Add("accept", "text/plain");
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var response = await client.GetAsync(apiUrl);
        var organization = JsonSerializer.Deserialize<Organization>(await response.Content.ReadAsStringAsync(),options);
        var addedOrganization = await Repository.InsertAsync(organization);

        return mapper.Map<OrganizationDto>(organization);
    }
}