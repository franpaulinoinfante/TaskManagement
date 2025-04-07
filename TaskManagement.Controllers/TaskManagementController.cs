using TaskManagement.Domain;
using TaskManagement.Domain.Implementations;
using TaskManagement.TaskViews;
using TaskManagement.TaskViews.CategoryViews;
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

    }

    public List<CategoryNodo> GetCategoryNodos => LoadCategoryTree.LoadCategoryNode(TaskItemListViews);

    public IReadOnlyList<TaskItemListView> TaskItemListViews
    {
        get
        {
            List<TaskItemListView> tasks = new List<TaskItemListView>();
            foreach (TaskItem taskItem in _taskList.TasksByPriorityAndDueDate)
            {
                tasks.Add(new TaskItemListView
                {
                    Id = taskItem.Id,
                    Title = taskItem.Title,
                    PriorityLevel = taskItem.PriorityLevel,
                    TaskStates = taskItem.TaskStates,
                    Category = taskItem.Category,
                    DueDate = taskItem.DueDate
                });
            }

            return tasks;
        }
    }

    public IReadOnlyList<TaskActionsHistoryView> TaskActionsHistory
    {
        get
        {
            List<TaskActionsHistoryView> historyTaskActions = new List<TaskActionsHistoryView>();
            IReadOnlyList<(ActionOnTask, TaskItem)> taskActions = _taskStack.TaskActionsHistory;
            foreach ((ActionOnTask, TaskItem) action in taskActions)
            {
                historyTaskActions.Add(new TaskActionsHistoryView()
                {
                    Id = action.Item2.Id,
                    Title = action.Item2.Title,
                    ActionOnTask = action.Item1
                });
            }

            return historyTaskActions;
        }
    }

    public IReadOnlyList<TaskUrgentsView> TaskItemUrgents
    {
        get
        {
            List<TaskUrgentsView> taskUrgents = new List<TaskUrgentsView>();
            foreach (TaskItem taskUrgent in _taskQueue.TaskUrgents)
            {
                taskUrgents.Add(new TaskUrgentsView
                {
                    Id = taskUrgent.Id,
                    Title = taskUrgent.Title,
                    Description = taskUrgent.Description,
                    PriorityLevel = taskUrgent.PriorityLevel,
                    TaskStates = taskUrgent.TaskStates,
                    Category = taskUrgent.Category,
                    DueDate = taskUrgent.DueDate
                });
            }

            return taskUrgents;
        }
    }

    public IReadOnlyList<TaskActionsRedoView> TaskActionsRedos
    {
        get
        {
            List<TaskActionsRedoView> taskActionsRedoView = new List<TaskActionsRedoView>();
            IReadOnlyList<(ActionOnTask, TaskItem)> taskActionsRedos = _taskStack.TaskActionsRedo;
            foreach ((ActionOnTask, TaskItem) redos in taskActionsRedos)
            {
                taskActionsRedoView.Add(new TaskActionsRedoView()
                {
                    Id = redos.Item2.Id,
                    Title = redos.Item2.Title,
                    ActionOnTask = redos.Item1
                });
            }

            return taskActionsRedoView;
        }
    }

    public TaskItemListView GetTaskItemById(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItem = _taskList.GetTask(id);
        if (taskItem is null)
        {
            throw new InvalidOperationException("Tarea no encontrada");
        }

        return new TaskItemListView()
        {
            Id = taskItem.Id,
            Title = taskItem.Title,
            Description = taskItem.Description,
            PriorityLevel = taskItem.PriorityLevel,
            TaskStates = taskItem.TaskStates,
            Category = taskItem.Category,
            DueDate = taskItem.DueDate
        };
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
            TaskStates = createView.TaskStates,
            Category = createView.Category,
            PriorityLevel = createView.PriorityLevel,
            DueDate = createView.DueDate
        };

        _taskList.Add(taskItem);
        _taskStack.Push(ActionOnTask.Create, taskItem.Clone);
    }

    public void UpdateTask(TaskItemUpdateView updateView)
    {
        if (updateView is null || updateView.Id <= 0)
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
        taskItemToUpdate.TaskStates = updateView.TaskStates;
        taskItemToUpdate.Category = updateView.Category;
        taskItemToUpdate.PriorityLevel = updateView.PriorityLevel;
        taskItemToUpdate.DueDate = updateView.DueDate;

        _taskStack.Push(ActionOnTask.Update, taskItemToUpdate.Clone);
        _taskList.Update(taskItemToUpdate);
    }

    public void DeleteTask(TaskItemRemoveView removeView)
    {
        if (removeView is null || removeView.Id <= 0)
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskToRemove = _taskList.GetTask(removeView.Id);
        if (taskToRemove is null)
        {
            throw new InvalidOperationException("Tarea para eliminar no encontrada");
        }

        taskToRemove.MarkAsDeleted();
        _taskStack.Push(ActionOnTask.Remove, taskToRemove.Clone);
        _taskList.Remove(taskToRemove);
    }

    public void Undo()
    {
        // preguntar al profesor si cuando realizo el undo o el redo, se actualiza la lista o solo se presentas las acciones en el historial stack????

        TaskItem taskItemBefore;
        if (_taskStack.IsLast)
        {
            taskItemBefore = _taskStack.Peek;
        }
        else
        {
            taskItemBefore = _taskStack.Undo();
        }

        TaskItem? taskItem = _taskList.GetTask(taskItemBefore.Id);
        if (taskItem is not null)
        {
            _taskList.Remove(taskItem);
            _taskList.Update(_taskStack.Peek);
        }
        else
        {
            _taskList.AddFromActions(_taskStack.Peek);
        }
    }

    public void Redo()
    {
        if (!_taskStack.CanDoRedo)
        {
            throw new InvalidOperationException("No existen acciones para rehacer");
        }

        TaskItem taskItemAfter = _taskStack.Redo();

        TaskItem? taskItem = _taskList.GetTask(taskItemAfter.Id);
        if (taskItem is not null)
        {
            _taskList.Remove(taskItem);
        }

        _taskList.AddFromActions(taskItemAfter);
    }

    public void MarkTaskUrgent(UpdatePriorityLevel updateLavelStateView)
    {
        if (updateLavelStateView == null || updateLavelStateView.PriorityLevel != PriorityLevel.Urgent || !(updateLavelStateView.Id > 0))
        {
            throw new ArgumentNullException();
        }

        TaskItem? taskItem = _taskList.GetTask(updateLavelStateView.Id);
        if (taskItem == null)
        {
            throw new InvalidOperationException("Tarea no encontrada");
        }

        if (taskItem.PriorityLevel == PriorityLevel.Urgent)
        {
            throw new InvalidOperationException("La tarea ya es urgente");
        }

        taskItem.MarkPriorityAsUrgent();

        _taskStack.Push(ActionOnTask.Update, taskItem.Clone);
        _taskList.Update(taskItem);
        _taskQueue.Enqueue(taskItem);
    }

    public bool AnyTask() => _taskList.TasksByPriorityAndDueDate.Any();

    public void ProcessUrgentTask()
    {
        if (!_taskQueue.Any())
        {
            throw new InvalidOperationException("No hay tareas urgentes");
        }

        TaskItem taskItem = _taskQueue.Dequeue();
        taskItem.MarkAsDone();
        _taskStack.Push(ActionOnTask.Update, taskItem);
        _taskList.RemoveAtId(taskItem.Id);
    }

    public bool AnyTaskUrgent()
    {
        return _taskQueue.Any();
    }

}
