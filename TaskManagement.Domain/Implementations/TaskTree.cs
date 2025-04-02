using TaskManagement.Utils;

namespace TaskManagement.Domain.Implementations;

public class TaskTree
{
    private readonly TreeNode<TaskItem> _taskTree;

    public TaskTree(TaskItem rootTask)
    {
        _taskTree = new TreeNode<TaskItem>(rootTask);
    }

    public void AddTask(TaskItem taskItem, int? parentId = null)
    {
        if (parentId == null)
        {
            _taskTree.AddChild(new TreeNode<TaskItem>(taskItem));
        }
        else
        {
            TreeNode<TaskItem>? taskParent = FindTask(_taskTree, parentId.Value);
            taskParent?.AddChild(new TreeNode<TaskItem>(taskItem));
        }
    }

    public TreeNode<TaskItem>? FindTask(TreeNode<TaskItem> node, int id)
    {
        if (node.Value.Id == id)
        {
            return node;
        }

        foreach (TreeNode<TaskItem> child in node.Children)
        {
            TreeNode<TaskItem>? found = FindTask(child, id);
            if (found != null)
            {
                return found;
            }
        }

        return null;
    }
}
