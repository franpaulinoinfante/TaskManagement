using TaskManagement.Types;

namespace TaskManagement.TaskViews.CategoryViews;

public class CategoryNodo
{
    public Category Category { get; set; }
    public List<CategoryNodo> Subcategories { get; private set; }
    public List<TaskItemListView> Tasks { get; private set; }

    public CategoryNodo(Category category)
    {
        Category = category;
        Subcategories = new List<CategoryNodo>();
        Tasks = new List<TaskItemListView>();
    }
    public void AddSubcategory(CategoryNodo subcategory)
    {
        Subcategories.Add(subcategory);
    }

    public void AddTask(TaskItemListView task)
    {
        Tasks.Add(task);
    }

    public bool AddTaskToCategory(Category targetCategory, TaskItemListView task)
    {
        if (Category == targetCategory)
        {
            Tasks.Add(task);
            return true; // Tarea agregada
        }

        foreach (var sub in Subcategories)
        {
            if (sub.AddTaskToCategory(targetCategory, task))
            {
                return true;
            }
        }

        return false;
    }
}
