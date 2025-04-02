using TaskManagement.Types;

namespace TaskManagement.TaskViews.TaskViews;

public record TaskItemView
{
    private List<TaskItemView> SubTasks { get; set; } = new List<TaskItemView>();

    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required TaskState TaskState { get; set; }
    public required Category Category { get; set; }
    public required PriorityLevel PriorityLevel { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime DueDate { get; set; }

    public List<TaskItemView> SubTask => SubTasks;

    public void AddSubTasks(TaskItemView item)
    {
        SubTasks.Add(item);
    }
}
