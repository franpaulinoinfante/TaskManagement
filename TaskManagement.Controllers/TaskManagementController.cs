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
    private readonly List<TaskTree> _taskTrees;

    public TaskManagementController()
    {
        _taskList = new();
        _taskStack = new();
        _taskQueue = new();
        _taskTrees = new();

        new SeedTasks().LoadSeed(_taskList, _taskStack);

        LoadTreeView();
    }

    public IReadOnlyList<TaskItemView> TaskTrees
    {
        get
        {
            LoadTreeView();
            List<TaskItemView> tasksViews = new();
            foreach (TaskItem taskItem in _taskList.Tasks)
            {
                TaskItemView taskItemView = new TaskItemView()
                {
                    Id = taskItem.Id,
                    Title = taskItem.Title,
                    Description = taskItem.Description,
                    TaskState = taskItem.TaskState,
                    Category = taskItem.Category,
                    PriorityLevel = taskItem.PriorityLevel,
                    CreatedAt = taskItem.CreatedAt,
                    DueDate = taskItem.DueDate,
                };

                AddSubTasksToView(taskItemView, taskItem.SubTasks);

                tasksViews.Add(taskItemView);
            }

            return tasksViews;
        }
    }

    private void LoadTreeView()
    {
        foreach (TaskItem taskItem in _taskList.Tasks)
        {
            TaskTree taskTree = new TaskTree(taskItem);
            _taskTrees.Add(taskTree);
        }
    }

    private void AddSubTasksToView(TaskItemView parentView, List<TaskItem> subTasks)
    {
        foreach (TaskItem subTask in subTasks)
        {
            TaskItemView subTaskView = new TaskItemView()
            {
                Id = subTask.Id,
                Title = subTask.Title,
                Description = subTask.Description,
                TaskState = subTask.TaskState,
                Category = subTask.Category,
                PriorityLevel = subTask.PriorityLevel,
                CreatedAt = subTask.CreatedAt,
                DueDate = subTask.DueDate,
            };

            parentView.AddSubTasks(subTaskView);

            AddSubTasksToView(subTaskView, subTask.SubTasks);
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
        _taskStack.Push(ActionOnTask.Create, taskItem);

        if (taskItem.PriorityLevel == Types.PriorityLevel.Urgent)
        {
            _taskQueue.Enqueue(taskItem);
        }
    }

    public void AddSubTask(TaskItemCreateView createView)
    {
        if (createView is null)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItemToUpdate = _taskList.GetTask(createView.Id);
        if (taskItemToUpdate is null)
        {
            throw new InvalidOperationException("Tarea a modificar no encontrada");
        }

        taskItemToUpdate.AddSubTask(new TaskItem
        {
            Title = createView.Title,
            Description = createView.Description,
            TaskState = createView.TaskState,
            Category = createView.Category,
            PriorityLevel = createView.PriorityLevel,
            DueDate = createView.DueDate
        });

        _taskStack.Push(ActionOnTask.Update, taskItemToUpdate);
    }

    public void Update(TaskItemUpdateView updateView)
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

    public void MarkUrgent(UpdateLavelStateView updateLavelStateView)
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

    public void MarkNormal(UpdateLavelStateView updateLavelStateView)
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
}
