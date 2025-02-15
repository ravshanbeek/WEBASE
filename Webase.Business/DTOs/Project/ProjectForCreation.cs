namespace Webase.Business.DTOs;

public class ProjectForCreation
{
    public int OrganizationId { get; set; }
    public string Name { get; set; }
    public DateOnly Deadline { get; set; }
    public int ProjectTypeId { get; set; }
    public int ProjectPriorityId { get; set; }
}