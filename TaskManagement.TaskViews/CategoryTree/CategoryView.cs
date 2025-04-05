using TaskManagement.Types;

namespace TaskManagement.TaskViews.CategoryTree;

public class CategoryView
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStates TaskStates { get; set; }
    public string Category { get; set; } = string.Empty;
    public PriorityLevel PriorityLevel { get; set; }
    public DateTime CreatedAt { get; init; }
    public DateTime DueDate { get; set; }
    public List<CategoryView> SubCategories { get; set; } = new List<CategoryView>();
}
