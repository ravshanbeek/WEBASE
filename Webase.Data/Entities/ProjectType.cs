using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class ProjectType
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public string? Typename { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
