using JonDou9000.TaskPlanner.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// JonDou9000.TaskPlanner.Domain.Models/Enums/Priority.cs
namespace JonDou9000.TaskPlanner.Domain.Models.Enums
{
    public enum Priority
    {
        None,
        Low,
        Medium,
        High,
        Urgent
    }
}

// JonDou9000.TaskPlanner.Domain.Models/Enums/Complexity.cs
namespace JonDou9000.TaskPlanner.Domain.Models.Enums
{
    public enum Complexity
    {
        None,
        Minutes,
        Hours,
        Days,
        Weeks
    }
}



namespace JonDou9000.TaskPlanner.Domain.Models
{
    public class WorkItem
    {
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Title}: due {DueDate.ToString("dd.MM.yyyy")}, {Priority.ToString().ToLower()} priority";
        }
    }
}
