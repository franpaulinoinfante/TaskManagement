using System.Diagnostics;

namespace TaskManagement.Domain.Implementations;

public class TaskQueue
{
    private readonly Queue<TaskItem> _taskQueue;

    public TaskQueue()
    {
        _taskQueue = [];
    }

    public IReadOnlyList<TaskItem> TaskUrgents => _taskQueue.ToList();

    public void Enqueue(TaskItem taskItem)
    {
        Debug.Assert(taskItem != null);

        _taskQueue.Enqueue(taskItem);
    }

    public TaskItem Dequeue()
    {
        Debug.Assert(_taskQueue.Count > 0);

        return _taskQueue.Dequeue().Clone;
    }

    public bool Any() => _taskQueue.Any();
}
