namespace Webase.Business.DTOs;

public record OrganizationDto(
    string Inn,
    string Name,
    int Okedid,
    string Address, 
    string? Accounter,
    string Director );