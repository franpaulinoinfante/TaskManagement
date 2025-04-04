namespace TaskManagement.Utils;

public class TreeNode<T>(T value)
{
    public T Value { get; set; } = value;
    public TreeNode<T>? Parent { get; private set; }
    public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

    public void AddChild(TreeNode<T> child)
    {
        child.Parent = this;
        Children.Add(child);
    }
}
