using TaskManagement.Domain;
using TaskManagement.Domain.Implementations;
using TaskManagement.TaskViews;
using TaskManagement.TaskViews.TaskListViews;
using TaskManagement.TaskViews.TaskViews;
using TaskManagement.Types;

namespace TaskManagement.Controllers;

public class TaskManagementController
{
    private readonly TaskList _taskList;
    private readonly TaskStack _taskStack;
    private readonly TaskQueue _taskQueue;

    public TaskManagementController()
    {
        _taskList = new();
        _taskStack = new();
        _taskQueue = new();

        LoadTreeView();
    }

    private void LoadTreeView()
    {

        List<TaskItemCreateView> taskSeed = new SeedTasks().GetSeedTask();
        foreach (TaskItemCreateView task in taskSeed)
        {
            AddTask(task);
        }

        List<TaskItemCreateView> subTaksSeed = new SeedSubTasks().GetSeedTask();
        foreach (TaskItemCreateView subTask in subTaksSeed)
        {
            AddSubTask(subTask);
        }
    }

    public void AddTask(TaskItemCreateView createView)
    {
        if (createView is null)
        {
            throw new ArgumentNullException();
        }

        TaskItem taskItem = new TaskItem()
        {
            Title = createView.Title,
            Description = createView.Description,
            TaskState = createView.TaskState,
            Category = createView.Category,
            PriorityLevel = createView.PriorityLevel,
            DueDate = createView.DueDate
        };

        _taskList.Add(taskItem);
        _taskStack.Push(ActionOnTask.Create, taskItem.Clone);

        if (taskItem.PriorityLevel == PriorityLevel.Urgent)
        {
            _taskQueue.Enqueue(taskItem.Clone);
        }
    }

    public void AddSubTask(TaskItemCreateView createView)
    {
        if (createView is null)
        {
            throw new ArgumentNullException();
        }

        TaskItem taskItem = new TaskItem()
        {
            Title = createView.Title,
            Description = createView.Description,
            TaskState = createView.TaskState,
            Category = createView.Category,
            PriorityLevel = createView.PriorityLevel,
            DueDate = createView.DueDate
        };

        TaskItem? taskItemToUpdate = _taskList.GetTask(createView.Id);
        if (taskItemToUpdate is null)
        {
            throw new InvalidOperationException("Tarea no encontrada, no se puede agregar una subtarea");
        }

        _taskList.Update(taskItemToUpdate);
        _taskStack.Push(ActionOnTask.Update, taskItemToUpdate.Clone);
    }

    public void UpdateTask(TaskItemUpdateView updateView)
    {
        if (updateView is null)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItemToUpdate = _taskList.GetTask(updateView.Id);
        if (taskItemToUpdate is null)
        {
            throw new InvalidOperationException("Tarea a modificar no encontrada");
        }

        taskItemToUpdate.Title = updateView.Title;
        taskItemToUpdate.Description = updateView.Description;
        taskItemToUpdate.TaskState = updateView.TaskState;
        taskItemToUpdate.Category = updateView.Category;
        taskItemToUpdate.PriorityLevel = updateView.PriorityLevel;
        taskItemToUpdate.DueDate = updateView.DueDate;

        _taskStack.Push(ActionOnTask.Update, taskItemToUpdate.Clone);
        _taskList.Update(taskItemToUpdate);

        if (taskItemToUpdate.PriorityLevel != PriorityLevel.Urgent)
        {
            _taskQueue.Dequeue(taskItemToUpdate);
        }
    }

    public void RemoveTask(TaskItemRemoveView removeView)
    {
        TaskItem? taskToRemove = _taskList.GetTask(removeView.Id);
        if (taskToRemove is null)
        {
            throw new InvalidOperationException("Tarea para eliminar no encontrada");
        }

        _taskStack.Push(ActionOnTask.Remove, taskToRemove.Clone);
        _taskList.Remove(taskToRemove);
    }

    public void UpdateState(UpdateTaskStateView updateTaskStateView)
    {
        if (updateTaskStateView == null)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItem = _taskList.GetTask(updateTaskStateView.Id);
        if (taskItem == null)
        {
            throw new InvalidOperationException("Tarea no encontrada");
        }

        taskItem.TaskState = updateTaskStateView.TaskState;
        _taskStack.Push(ActionOnTask.Update, taskItem.Clone);
        _taskList.Update(taskItem);
    }

    public void MarkTaskUrgent(UpdateLavelStateView updateLavelStateView)
    {
        if (updateLavelStateView == null || updateLavelStateView.PriorityLevel != PriorityLevel.Urgent)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItem = _taskList.GetTask(updateLavelStateView.Id);
        if (taskItem == null)
        {
            throw new InvalidOperationException("Tarea no encontrada");
        }

        taskItem.PriorityLevel = updateLavelStateView.PriorityLevel;

        _taskStack.Push(ActionOnTask.Update, taskItem.Clone);
        _taskList.Update(taskItem);
        _taskQueue.Enqueue(taskItem);
    }

    public void MarkTaskNormal(UpdateLavelStateView updateLavelStateView)
    {
        if (updateLavelStateView == null || updateLavelStateView.PriorityLevel != PriorityLevel.Normal)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItem = _taskList.GetTask(updateLavelStateView.Id);
        if (taskItem == null)
        {
            throw new InvalidOperationException("Tarea no encontrada");
        }

        taskItem.PriorityLevel = updateLavelStateView.PriorityLevel;

        _taskStack.Push(ActionOnTask.Update, taskItem.Clone);
        _taskList.Update(taskItem);
        _taskQueue.Enqueue(taskItem);
    }

    public void Undo()
    {
        if (_taskStack.HistoryTasks.Count > 0)
        {
            _taskStack.Undo();
        }
    }

    public void Redo()
    {
        if (_taskStack.RedoTasks.Count > 0)
        {
            _taskStack.Redo();
        }
    }
}
