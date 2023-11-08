namespace Webase.Business.DTOs.Task;

public record TaskForCreation(
    int projectId,
    string name,
    DateOnly startDate,
    DateOnly endDate,
    List<int> employeeIds);