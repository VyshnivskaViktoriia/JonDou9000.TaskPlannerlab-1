using System;
using JonDou9000.TaskPlanner.Domain.Logic;
using JonDou9000.TaskPlanner.Domain.Models;
using JonDou9000.TaskPlanner.Domain.Models.Enums;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Ваш код тут
        // Наприклад, введення робочих елементів і виклик CreatePlan для впорядкування.

        var taskPlanner = new SimpleTaskPlanner();

        // Приклад ініціалізації робочих елементів (замініть на свої дані)
        var workItems = new WorkItem[]
        {
            new WorkItem { Title = "Task 1", DueDate = DateTime.Now.AddDays(3), Priority = Priority.High },
            new WorkItem { Title = "Task 2", DueDate = DateTime.Now.AddDays(1), Priority = Priority.Medium },
            new WorkItem { Title = "Task 3", DueDate = DateTime.Now.AddDays(2), Priority = Priority.Urgent }
        };

        var sortedWorkItems = taskPlanner.CreatePlan(workItems);

        // Вивід відсортованих робочих елементів
        foreach (var item in sortedWorkItems)
        {
            Console.WriteLine(item);
        }

        // Затримка, щоб консольне вікно не закрилося відразу після виводу результатів
        Console.ReadLine();
    }
}

