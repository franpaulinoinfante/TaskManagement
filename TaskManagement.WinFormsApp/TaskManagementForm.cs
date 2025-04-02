using TaskManagement.Controllers;
using TaskManagement.TaskViews.TaskViews;

namespace TaskManagement.WinFormsApp;
public partial class TaskManagementForm : Form
{
    private readonly TaskManagementController _taskItemController;

    public TaskManagementForm()
    {
        InitializeComponent();
        _taskItemController = new TaskManagementController();

        LoadTaskItems();
    }

    private void LoadTaskItems()
    {
        treeViewTasks.Nodes.Clear();
        foreach (TaskItemView taskItem in _taskItemController.TaskTrees)
        {
            TreeNode node = new TreeNode(taskItem.Title)
            {
                Tag = taskItem
            };
            node.Nodes.Add($"Titulo: {taskItem.Description}");
            node.Nodes.Add($"Descripción: {taskItem.Description}");
            node.Nodes.Add($"Estado: {taskItem.TaskState}");
            node.Nodes.Add($"Categoria: {taskItem.Category}");
            node.Nodes.Add($"Prioridad: {taskItem.PriorityLevel}");
            node.Nodes.Add($"Fecha de Vencimiento: {taskItem.DueDate}");
            treeViewTasks.Nodes.Add(node);

            foreach (TaskItemView subTask in taskItem.SubTas)
            {
                TreeNode subNode = new TreeNode(subTask.Title)
                {
                    Tag = taskItem
                };
                subNode.Nodes.Add($"Titulo: {subTask.Description}");
                subNode.Nodes.Add($"Descripción: {subTask.Description}");
                subNode.Nodes.Add($"Estado: {subTask.TaskState}");
                subNode.Nodes.Add($"Categoria: {subTask.Category}");
                subNode.Nodes.Add($"Prioridad: {subTask.PriorityLevel}");
                subNode.Nodes.Add($"Fecha de Vencimiento: {subTask.DueDate}");
                node.Nodes.Add(subNode);
            }

        }
    }
}
