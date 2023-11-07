using Webase.Business.DTOs.Profission;

namespace Webase.Business.DTOs;

public record EmployeeForModification(
    int id,
    string firstname,
    string lastName,
    string? telephoneNumber,
    string? email,
    int profissionId);