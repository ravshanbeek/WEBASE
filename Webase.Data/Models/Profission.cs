using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Profission
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
