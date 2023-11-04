using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Task
{
    public int Id { get; set; }

    public int? Projectid { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public DateOnly? Completiondate { get; set; }

    public int? Status { get; set; }

    public virtual ProjectType? Project { get; set; }

    public virtual TaskStatus? StatusNavigation { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
