namespace Webase.Business.DTOs;

public record ProjectDto(
    int id,
    int organizationid,
    string name,
    DateTime deadline,
    ProjectTypeDto type,
    PriorityStatusDto priority);