using System.Diagnostics;
using TaskManagement.Types;

namespace TaskManagement.Domain.Implementations;

public class TaskStack
{
    private readonly Stack<(ActionOnTask, TaskItem)> _historyTasks;
    private readonly Stack<(ActionOnTask, TaskItem)> _redoTasks;

    public TaskStack()
    {
        _historyTasks = new Stack<(ActionOnTask, TaskItem)>();
        _redoTasks = new Stack<(ActionOnTask, TaskItem)>();
    }

    public IReadOnlyList<(ActionOnTask, TaskItem)> HistoryTaskActions => _historyTasks.ToList();

    public IReadOnlyList<(ActionOnTask, TaskItem)> RedoTasks => _redoTasks.ToList();

    public void Push(ActionOnTask action, TaskItem taskItem)
    {
        Debug.Assert(taskItem != null);

        _historyTasks.Push((action, taskItem));
        _redoTasks.Clear();
    }

    public void Undo()
    {
        _redoTasks.Push(_historyTasks.Pop());
    }

    public void Redo()
    {
        _historyTasks.Push(_redoTasks.Pop());
    }
}
