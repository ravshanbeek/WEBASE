namespace Webase.Business.DTOs;

public record ProjectDto(
    int id,
    int organizationid,
    string name,
    DateTime deadline,
    string projectType,
    string projectPriority);