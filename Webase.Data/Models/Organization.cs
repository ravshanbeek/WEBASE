using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Organization
{
    public int Id { get; set; }

    public string Inn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Okedid { get; set; }

    public string Address { get; set; } = null!;

    public string Accounter { get; set; } = null!;

    public string Director { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
