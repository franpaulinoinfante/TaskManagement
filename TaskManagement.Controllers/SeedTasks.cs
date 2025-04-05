using TaskManagement.TaskViews;
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
            TaskStates = TaskStates.ToDo,
            Category = Category.Work,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now
        };
        taskItems.Add(taskItem1);

        TaskItemCreateView taskItem2 = new TaskItemCreateView()
        {
            Title = "Test 2",
            Description = "Sub Probando funciones 2",
            TaskStates = TaskStates.Done,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now
        };
        taskItems.Add(taskItem2);

        TaskItemCreateView taskItem3 = new TaskItemCreateView()
        {
            Title = "Test 3",
            Description = "Probando funciones",
            TaskStates = TaskStates.InProgress,
            Category = Category.Work,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now,
        };
        taskItems.Add(taskItem3);

        return taskItems;
    }
}