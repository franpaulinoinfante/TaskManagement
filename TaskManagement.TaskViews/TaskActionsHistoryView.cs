using TaskManagement.Types;

namespace TaskManagement.TaskViews;

public class TaskActionsHistoryView
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required ActionOnTask ActionOnTask { get; set; }
}
