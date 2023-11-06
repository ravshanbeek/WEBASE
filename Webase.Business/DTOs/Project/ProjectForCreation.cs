namespace Webase.Business.DTOs;

public record ProjectForCreation(
    int organizationid,
    string name,
    DateTime deadline,
    ProjectTypeDto type,
    PriorityStatusDto priority);