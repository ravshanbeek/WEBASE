using System;
using System.Collections.Generic;

namespace Webase.Business.DTOs.Task
{
    public class TaskDto
    {
        public int Id { get; init; }
        public int ProjectId { get; init; }
        public string Name { get; init; }
        public DateOnly StartDate { get; init; }
        public DateOnly EndDate { get; init; }
        public DateOnly CompletionDate { get; init; }
        public string TaskStatus { get; init; }
        public List<string> Employees { get; init; }
    }
}