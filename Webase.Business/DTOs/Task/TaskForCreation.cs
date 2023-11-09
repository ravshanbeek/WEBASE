using System;
using System.Collections.Generic;

namespace Webase.Business.DTOs.Task
{
    public class TaskForCreation
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<int> EmployeeIds { get; set; }
    }
}