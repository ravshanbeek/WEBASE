namespace Webase.Business.DTOs.Task;

public record TaskForModification(
    int id,
    int projectId,
    string name,
    DateOnly startDate,
    DateOnly endDate,
    TaskStatusDto status,
    ICollection<EmployeeDto> employees);