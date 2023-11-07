﻿using System;
using System.Collections.Generic;

namespace Webase.Data;

public partial class TaskStatus
{
    public int Id { get; set; }

    public string? Statusname { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
