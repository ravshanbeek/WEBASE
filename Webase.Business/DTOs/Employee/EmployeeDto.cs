using Webase.Business.DTOs.Profission;

namespace Webase.Business.DTOs;

public record EmployeeDto(
    int id,
    string firstname,
    string lastName,
    string? telephoneNumber,
    string? email,
    string profissionName);