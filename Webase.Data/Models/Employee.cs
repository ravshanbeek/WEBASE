using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class Employee
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Phonenumber { get; set; }

    public string? Email { get; set; }

    public int Profissionid { get; set; }

    public virtual Profission? Profission { get; set; }
    
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
