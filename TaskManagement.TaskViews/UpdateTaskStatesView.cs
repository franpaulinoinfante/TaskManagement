using TaskManagement.Types;

namespace TaskManagement.TaskViews;

public record UpdateTaskStatesView
{
    public required int Id { get; set; }
    public required TaskStates TaskStates { get; set; }
}
