namespace TaskManagement.WinFormsApp;

partial class TaskManagementForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        treeViewTasks = new TreeView();
        SuspendLayout();
        // 
        // treeViewTasks
        // 
        treeViewTasks.Location = new Point(12, 12);
        treeViewTasks.Name = "treeViewTasks";
        treeViewTasks.Size = new Size(456, 426);
        treeViewTasks.TabIndex = 0;
        // 
        // TaskManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(treeViewTasks);
        Name = "TaskManagementForm";
        Text = "TaskManagementForm";
        ResumeLayout(false);
    }

    #endregion

    private TreeView treeViewTasks;
}