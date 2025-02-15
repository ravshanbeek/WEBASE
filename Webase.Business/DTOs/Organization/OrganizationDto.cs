namespace Webase.Business.DTOs;

public class OrganizationDto
{
    public int Id { get; set; }
    public string Inn { get; init; }
    public string ShortName { get; init; }
    public int OkedId { get; init; }
    public string Address { get; init; }
    public string? Accounter { get; init; }
    public string Director { get; init; }
}