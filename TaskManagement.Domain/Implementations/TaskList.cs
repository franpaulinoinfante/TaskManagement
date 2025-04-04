using System.Diagnostics;

namespace TaskManagement.Domain.Implementations;

public class TaskList
{
    private readonly List<TaskItem> _tasks;

    private int _id;

    public TaskList()
    {
        _tasks = [];
        _id = default;
    }

    public List<TaskItem> TasksByPriorityAndDueDate => _tasks
                .OrderByDescending(t => t.PriorityLevel)
                .ThenBy(t => t.DueDate)
                .ToList();

    public TaskItem? GetTask(int id)
    {
        Debug.Assert(id >= 0);

        return _tasks.FirstOrDefault(d => d.Id == id);
    }

    public void Add(TaskItem task)
    {
        Debug.Assert(task != null);

        task.Id = ++_id;
        _tasks.Add(task);
    }

    public void AddRedo(TaskItem task)
    {
        Debug.Assert(task != null);

        _tasks.Add(task);
    }

    public void Update(TaskItem taskItemToUpdate)
    {
        Debug.Assert(taskItemToUpdate != null);

        int index = _tasks.FindIndex(t => t.Id == taskItemToUpdate.Id);
        if (index >= 0)
        {
            _tasks[index] = taskItemToUpdate;
        }
    }

    public void Remove(TaskItem task)
    {
        Debug.Assert(task != null);

        _tasks.Remove(task);
    }

    public void RemoveAtId(int id)
    {
        Debug.Assert(id >= 0);
        Debug.Assert(_tasks.Count > 0);

        TaskItem? task = GetTask(id);
        if (task != null)
        {
            _tasks.Remove(task);
        }
    }
}
