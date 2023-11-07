using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Project
{
    public int Id { get; set; }

    public int Organizationid { get; set; }

    public string Name { get; set; } = null!;

    public int Typeid { get; set; }

    public int Priorityid { get; set; }

    public DateOnly Deadline { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual PriorityStatus Priority { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ProjectType Type { get; set; } = null!;
}
