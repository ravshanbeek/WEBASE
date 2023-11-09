namespace Webase.Business.DTOs;

public class EmployeeForModification
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string LastName { get; set; }
    public string? TelephoneNumber { get; set; }
    public string? Email { get; set; }
    public int ProfissionId { get; set; }
}