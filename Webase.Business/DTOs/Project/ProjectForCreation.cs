namespace Webase.Business.DTOs;

public record ProjectForCreation(
    int organizationid,
    string name,
    DateTime deadline,
    int projectType,
    int projectPriority);