namespace Webase.Business.DTOs;

public class EmployeeDto
{
    public int Id { get; init; }
    public string Firstname { get; init; }
    public string LastName { get; init; }
    public string? TelephoneNumber { get; init; }
    public string? Email { get; init; }
    public string ProfissionName { get; init; }
}