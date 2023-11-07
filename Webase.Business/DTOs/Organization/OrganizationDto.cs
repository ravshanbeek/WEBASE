namespace Webase.Business.DTOs;

public record OrganizationDto(
    string inn,
    string name,
    int okedid,
    string address, 
    string? accounter,
    string director );