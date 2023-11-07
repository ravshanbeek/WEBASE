using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Task
{
    public int Id { get; set; }

    public int Projectid { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public DateOnly? Completiondate { get; set; }

    public int? Statusid { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual TaskStatus? Status { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
