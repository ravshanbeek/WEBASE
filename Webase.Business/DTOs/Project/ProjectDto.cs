namespace Webase.Business.DTOs;

public class ProjectDto
{
    public int Id { get; init; }
    public int OrganizationId { get; init; }
    public string Name { get; init; }
    public DateTime Deadline { get; init; }
    public string ProjectType { get; init; }
    public string ProjectPriority { get; init; }
}