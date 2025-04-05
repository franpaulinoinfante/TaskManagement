using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Utils;

namespace TaskManagement.TaskViews.CategoryTree;

public class CategoryTree
{
    private TreeNode<CategoryView> _categoryTree;

    public CategoryTree(CategoryView categoryView)
    {
        _categoryTree = new TreeNode<CategoryView>(categoryView);
    }

    public TreeNode<CategoryView>? FindNode(TreeNode<CategoryView> node, int id)
    {
        if (node.Value.Id == id)
        {
            return node;
        }

        foreach (var child in node.Children)
        {
            var founded = FindNode(child, id);
            if (founded != null)
            {
                return founded;
            }
        }

        return null;
    }

    public void AddCategory(CategoryView categoryView, int? parentId = null)
    {
        if (parentId == null)
        {
            _categoryTree.AddChild(new TreeNode<CategoryView>(categoryView));
        }
        else
        {
            var parentNode = FindNode(_categoryTree, parentId.Value);
            parentNode?.AddChild(new TreeNode<CategoryView>(categoryView));
        }
    }
}
