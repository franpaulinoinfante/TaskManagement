using TaskManagement.TaskViews;
using TaskManagement.TaskViews.CategoryViews;
using TaskManagement.Types;

namespace TaskManagement.Controllers;

public class LoadCategoryTree
{
    public static List<CategoryNodo> LoadCategoryNode(IReadOnlyList<TaskItemListView> tasks)
    {
        List<CategoryNodo> categoryTree = new List<CategoryNodo>();
        Category[] categories = MainCategory.Categories;
        Dictionary<Category, Category[]> subCategories = SubCategories.SubCategoriesDic;

        foreach (Category category in categories)
        {
            CategoryNodo categoryNode = new CategoryNodo(category);
            categoryTree.Add(categoryNode);
            if (subCategories.ContainsKey(category))
            {
                foreach (Category subCategory in subCategories[category])
                {
                    CategoryNodo subCategoryNode = new CategoryNodo(subCategory);
                    categoryNode.AddSubcategory(subCategoryNode);
                }
            }
        }

        foreach (TaskItemListView task in tasks)
        {
            if (!(task.TaskStates == TaskStates.Done) && !(task.TaskStates == TaskStates.Deleted))
            {
                Category taskCategory = task.Category;
                foreach (CategoryNodo categoryNode in categoryTree)
                {
                    foreach (var item in categoryNode.Subcategories)
                    {

                        item.AddTaskToCategory(taskCategory, task);
                    }
                }
            }
        }

        return categoryTree;
    }
}
