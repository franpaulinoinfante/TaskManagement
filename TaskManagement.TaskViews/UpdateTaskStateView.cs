using TaskManagement.Types;

namespace TaskManagement.TaskViews;

public record UpdateTaskStateView
{
    public required int Id { get; set; }
    public required TaskState TaskState { get; set; }
}
