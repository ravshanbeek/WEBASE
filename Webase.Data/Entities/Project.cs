using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Project
{
    public int Id { get; set; }

    public int? Organizationid { get; set; }

    public string Name { get; set; } = null!;

    public int? Type { get; set; }

    public int? Priority { get; set; }

    public DateOnly? Deadline { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual PriorityStatus? PriorityNavigation { get; set; }

    public virtual ProjectType? TypeNavigation { get; set; }
}
