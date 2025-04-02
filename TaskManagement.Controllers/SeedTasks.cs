using TaskManagement.Domain;
using TaskManagement.Types;

namespace TaskManagement.Controllers;
internal class SeedTasks
{

    internal void LoadSeed(Domain.Implementations.TaskList taskList, Domain.Implementations.TaskStack taskStack)
    {
        TaskItem taskItem1 = new TaskItem()
        {
            Id = 1,
            Title = "Test 1",
            Description = "Probando funciones",
            TaskState = TaskState.Todo,
            Category = Category.Trabajo,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now
        };

        taskItem1.AddSubTask(new TaskItem
        {
            Title = "SubTest 1",
            Description = "Sub Probando funciones 1",
            TaskState = TaskState.Done,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now
        });

        taskList.Add(taskItem1);
        taskStack.Push(ActionOnTask.Create, taskItem1);

        TaskItem taskItem2 = new TaskItem()
        {
            Id = 2,
            Title = "Test 2",
            Description = "Sub Probando funciones 2",
            TaskState = TaskState.Done,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now
        };

        taskItem2.AddSubTask(new TaskItem
        {
            Title = "SubTest 2",
            Description = "Sub Probando funciones 2",
            TaskState = TaskState.InProgress,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now,
        });

        taskList.Add(taskItem2);
        taskStack.Push(ActionOnTask.Create, taskItem2);

        TaskItem taskItem3 = new TaskItem()
        {
            Id = 3,
            Title = "Test 3",
            Description = "Probando funciones",
            TaskState = TaskState.InProgress,
            Category = Category.Trabajo,
            PriorityLevel = PriorityLevel.Urgent,
            DueDate = DateTime.Now,
        };

        taskItem3.AddSubTask(new TaskItem
        {
            Title = "SubTest 3",
            Description = "Sub Probando funciones 3",
            TaskState = TaskState.InProgress,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now,
        });

        taskItem3.AddSubTask(new TaskItem
        {
            Title = "SubTest 3",
            Description = "Sub Probando funciones 3",
            TaskState = TaskState.InProgress,
            Category = Category.Personal,
            PriorityLevel = PriorityLevel.Normal,
            DueDate = DateTime.Now,
        });

        taskList.Add(taskItem3);
        taskStack.Push(ActionOnTask.Create, taskItem3);
    }
}
