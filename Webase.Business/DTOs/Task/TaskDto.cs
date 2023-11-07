namespace Webase.Business.DTOs.Task;

public record TaskDto(
    int id,
    int projectId,
    string name,
    DateOnly startDate,
    DateOnly endDate,
    DateOnly completionDate,
    TaskStatusDto status,
    ICollection<EmployeeDto> employees);