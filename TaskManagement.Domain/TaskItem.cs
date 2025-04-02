using TaskManagement.Types;

namespace TaskManagement.Domain;

public class TaskItem
{
    private int _id;

    public TaskItem()
    {
        CreatedAt = DateTime.Now;
    }

    public int Id
    {
        get => _id;
        set
        {
            if (_id == 0)
            {
                _id = value;
            }
        }
    }

    public required string Title { get; set; }
    public required string Description { get; set; }
    public required TaskState TaskState { get; set; }
    public required Category Category { get; set; }
    public required PriorityLevel PriorityLevel { get; set; }
    public DateTime CreatedAt { get; init; }
    public required DateTime DueDate { get; set; }

    public List<TaskItem> SubTasks { get; set; } = new List<TaskItem>();

    public TaskItem Clone => new TaskItem
    {
        Id = this.Id,
        Title = this.Title,
        Description = this.Description,
        TaskState = this.TaskState,
        Category = this.Category,
        PriorityLevel = this.PriorityLevel,
        CreatedAt = this.CreatedAt,
        DueDate = this.DueDate,
    };

    public void AddSubTask(TaskItem item)
    {
        SubTasks.Add(item);
    }
}
