namespace Webase.Business.DTOs;

public class ProjectForCreation
{
    public int OrganizationId { get; set; }
    public string Name { get; set; }
    public DateTime Deadline { get; set; }
    public int ProjectType { get; set; }
    public int ProjectPriority { get; set; }
}