using System.Diagnostics;

namespace TaskManagement.Domain.Implementations;

public class TaskQueue
{
    private readonly Queue<TaskItem> _taskQueue;

    public TaskQueue()
    {
        _taskQueue = [];
    }

    public IReadOnlyList<TaskItem> UrgentTasks => _taskQueue.ToList();

    public void Enqueue(TaskItem taskItem)
    {
        Debug.Assert(taskItem != null);

        _taskQueue.Enqueue(taskItem);
    }

    public void Dequeue(TaskItem taskItem)
    {
        Debug.Assert(taskItem != null);

        _taskQueue.Dequeue();
    }
}
