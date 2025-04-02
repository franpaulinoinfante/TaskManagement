using TaskManagement.TaskViews.TaskListViews;
using TaskManagement.Types;

namespace TaskManagement.Controllers;
internal class SeedTasks
{
    internal List<TaskItemCreateView> GetSeedTask()
    {
        List<TaskItemCreateView> taskItems = new List<TaskItemCreateView>();

        TaskItemCreateView taskItem1 = new TaskItemCreateView()
        {
            Title = "Test 1",
            Description = "Probando funciones",
            TaskState = TaskState.ToDo,
            Category = Category.Trabajo,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now
        };
        taskItems.Add(taskItem1);

        TaskItemCreateView taskItem2 = new TaskItemCreateView()
        {
            Title = "Test 2",
            Description = "Sub Probando funciones 2",
            TaskState = TaskState.Done,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now
        };
        taskItems.Add(taskItem2);

        TaskItemCreateView taskItem3 = new TaskItemCreateView()
        {
            Title = "Test 3",
            Description = "Probando funciones",
            TaskState = TaskState.InProgress,
            Category = Category.Trabajo,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now,
        };
        taskItems.Add(taskItem3);

        return taskItems;
    }
}

internal class SeedSubTasks
{
    internal List<TaskItemCreateView> GetSeedTask()
    {
        List<TaskItemCreateView> taskItems = new List<TaskItemCreateView>();

        TaskItemCreateView subTaskItem1 = new TaskItemCreateView()
        {
            Id = 1,
            Title = "SubTest 1",
            Description = "Sub Probando funciones 1",
            TaskState = TaskState.Done,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now
        };
        taskItems.Add(subTaskItem1);

        TaskItemCreateView subTaskItem2 = new TaskItemCreateView()
        {
            Id = 2,
            Title = "SubTest 2",
            Description = "Sub Probando funciones 2",
            TaskState = TaskState.InProgress,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now
        };
        taskItems.Add(subTaskItem2);

        TaskItemCreateView subTaksItem31 = new TaskItemCreateView()
        {
            Id = 3,
            Title = "SubTest 3-1",
            Description = "Sub Probando funciones 3-1",
            TaskState = TaskState.ToDo,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now,
        };
        taskItems.Add(subTaksItem31);

        TaskItemCreateView subTaksItem32 = new TaskItemCreateView()
        {
            Id = 3,
            Title = "SubTest 3-2",
            Description = "Sub Probando funciones 3-2",
            TaskState = TaskState.InProgress,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now,
        };
        taskItems.Add(subTaksItem32);

        return taskItems;
    }
}