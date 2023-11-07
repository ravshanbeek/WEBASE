using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class PriorityStatus
{
    public int Id { get; set; }

    public string? Statusname { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
