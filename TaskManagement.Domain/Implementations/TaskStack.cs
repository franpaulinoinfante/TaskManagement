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

    public IReadOnlyList<(ActionOnTask, TaskItem)> TaskActionsHistory => _historyTasks.ToList();

    public IReadOnlyList<(ActionOnTask, TaskItem)> TaskActionsRedo => _redoTasks.ToList();

    public bool CanDoUndo => _historyTasks.Count >= 1;

    public bool CanDoRedo => _historyTasks.Count > 0;

    public bool IsLast => _historyTasks.Count == 1;

    public TaskItem Peek => _historyTasks.Peek().Item2.Clone;

    public void Push(ActionOnTask action, TaskItem taskItem)
    {
        Debug.Assert(taskItem != null);

        _historyTasks.Push((action, taskItem));
        _redoTasks.Clear();
    }

    public TaskItem Undo()
    {
        TaskItem peek = Peek;
        if (CanDoUndo)
        {
            _redoTasks.Push(_historyTasks.Pop());
        }

        return peek;
    }

    public TaskItem Redo()
    {
        if (CanDoRedo)
        {
            _historyTasks.Push(_redoTasks.Pop());
        }

        return _historyTasks.Peek().Item2.Clone;
    }
}
