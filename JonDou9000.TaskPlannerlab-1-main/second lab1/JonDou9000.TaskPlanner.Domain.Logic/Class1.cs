// JonDou9000.TaskPlanner.Domain.Logic/SimpleTaskPlanner.cs
using System;
using System.Collections.Generic;
using JonDou9000.TaskPlanner.Domain.Models;

namespace JonDou9000.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {
        public WorkItem[] CreatePlan(WorkItem[] items)
        {
            var itemsAsList = new List<WorkItem>(items);
            itemsAsList.Sort(CompareWorkItems);
            return itemsAsList.ToArray();
        }

        private static int CompareWorkItems(WorkItem firstItem, WorkItem secondItem)
        {
            // Implement your comparison logic here
            // Example: Priority descending, DueDate ascending, Title alphabetical
            if (firstItem.Priority != secondItem.Priority)
                return secondItem.Priority.CompareTo(firstItem.Priority);

            if (firstItem.DueDate != secondItem.DueDate)
                return firstItem.DueDate.CompareTo(secondItem.DueDate);

            return string.Compare(firstItem.Title, secondItem.Title, StringComparison.Ordinal);
        }
    }
}
