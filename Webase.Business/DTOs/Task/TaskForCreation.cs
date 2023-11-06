namespace Webase.Business.DTOs.Task;

public record TaskForCreation(
    int projectId,
    string name,
    DateTime startDate,
    DateTime endDate,
    DateTime completionDate
    );