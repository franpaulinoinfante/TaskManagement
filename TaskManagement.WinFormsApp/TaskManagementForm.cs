using System.ComponentModel;
using TaskManagement.Controllers;
using TaskManagement.TaskViews.TaskListViews;
using TaskManagement.Types;

namespace TaskManagement.WinFormsApp;

public partial class TaskManagementForm : Form
{
    private readonly TaskManagementController _taskManagementController;

    private bool _isNew;

    public TaskManagementForm()
    {
        InitializeComponent();

        _isNew = true;

        _taskManagementController = new TaskManagementController();
        SetUpListsViews();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        get
        {
            bool isValid = int.TryParse(txtId.Text, out int id);
            if (!isValid)
            {
                MessageBox.Show("No se puede leer el Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
        set
        {
            txtId.Text = value.ToString();
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Title
    {
        get
        {
            return txtTitle.Text;
        }
        set
        {
            txtTitle.Text = value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Category Category
    {
        get
        {
            Category[] categories = Enum.GetValues<Category>();
            return categories[cbbCategory.SelectedIndex];
        }
        set
        {
            cbbCategory.SelectedIndex = (int)value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PriorityLevel PriorityLevel
    {
        get
        {
            if (rdbNormal.Checked)
            {
                return PriorityLevel.Normal;
            }
            else
            {
                return Types.PriorityLevel.Urgent;
            }
        }
        set
        {
            if (value == PriorityLevel.Normal)
            {
                rdbNormal.Checked = true;
            }
            else
            {
                rdbUrgent.Checked = true;
            }

        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public TaskState TaskState
    {
        get
        {
            if (rdbToDo.Checked)
            {
                return Types.TaskState.ToDo;
            }

            if (rdbInProgress.Checked)
            {
                return Types.TaskState.InProgress;
            }

            return TaskState.Done;
        }
        set
        {
            switch (value)
            {
                case TaskState.ToDo:
                    rdbToDo.Checked = true;
                    break;
                case TaskState.InProgress:
                    rdbInProgress.Checked = true;
                    break;
                case TaskState.Done:
                    rdbDone.Checked = true;
                    break;
            }
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Description
    {
        get
        {
            return txtDescription.Text;
        }
        set
        {
            txtDescription.Text = value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DateTime DueDate
    {
        get
        {
            if (dtpDueDate.Value <= DateTime.Now)
            {
                dtpDueDate.Value.Add(TimeSpan.FromSeconds(10));
            }
            return dtpDueDate.Value;
        }
        set
        {
            dtpDueDate.Value = value;
        }
    }

    private void SetUpListsViews()
    {
        listTaksItems.View = View.Details;
        listTaksItems.Columns.Add("Id", 50);
        listTaksItems.Columns.Add("Title", 310);
        listTaksItems.Columns.Add("Priodidad", 85);
        listTaksItems.Columns.Add("Estado", 100);
        listTaksItems.Columns.Add("Categoria", 175);
        listTaksItems.Columns.Add("Fecha Vencimiento", 160);

        listTaskHistoryStack.View = View.Details;
        listTaskHistoryStack.Columns.Add("Id", 50);
        listTaskHistoryStack.Columns.Add("Title", 150);
        listTaskHistoryStack.Columns.Add("Acción", 100);
    }

    private void TaskManagementForm_Load(object sender, EventArgs e)
    {
        LoadCategories();

        if (listTaksItems.Items.Count > 0)
        {
            btnUpdate.Enabled = true;
        }
        //DisplayTaskByPriorityAndDueDate();
    }

    private void LoadCategories()
    {
        foreach (Category item in Enum.GetValues<Types.Category>())
        {
            cbbCategory.Items.Add(item.GetMesage());
        }

        cbbCategory.SelectedIndex = 0;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!IsValidFields())
        {
            MessageBox.Show("Debe introducir todos los campos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            switch (_isNew)
            {
                case true:
                    _taskManagementController.AddTask(new TaskItemCreateView()
                    {
                        Title = this.Title,
                        Description = this.Description,
                        TaskState = this.TaskState,
                        Category = this.Category,
                        PriorityLevel = this.PriorityLevel,
                        DueDate = this.DueDate
                    });
                    break;
                case false:
                    _taskManagementController.UpdateTask(new TaskItemUpdateView()
                    {
                        Id = Id,
                        Title = Title,
                        Description = Description,
                        TaskState = TaskState,
                        Category = Category,
                        PriorityLevel = PriorityLevel,
                        DueDate = DueDate
                    });
                    break;
            }
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            DisabledFields();
            ClearFields();
            DisplayTaskActionHistory();
        }

        DisplayTaskByPriorityAndDueDate();
        SetValueToFields(listTaksItems.Items.Count);
    }

    private bool IsValidFields()
    {
        if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Description) ||
            (Category == Types.Category.None) || (DueDate < DateTime.Today))
        {
            return false;
        }

        return true;
    }

    private void DisplayTaskByPriorityAndDueDate()
    {
        listTaksItems.Items.Clear();

        try
        {
            IReadOnlyList<TaskItemListView> taskItems = _taskManagementController.TaskItemListViews;
            if (!taskItems.Any())
            {
                MessageBox.Show("No se ha creado tarea", "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (TaskItemListView taskItem in taskItems)
            {
                listTaksItems.Items.Add(new ListViewItem(new[]
                {
                    taskItem.Id.ToString(),
                    taskItem.Title,
                    taskItem.PriorityLevel.GetMesage(),
                    taskItem.TaskState.GetMesage(),
                    taskItem.Category.GetMesage(),
                    taskItem.DueDate.ToString()
                }));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void listTaksItems_Click(object sender, EventArgs e)
    {
        if ((listTaksItems.SelectedItems.Count > 0) && int.TryParse(listTaksItems.SelectedItems[0].Text, out int id))
        {
            SetValueToFields(id);
        }
    }

    private void SetValueToFields(int id)
    {
        try
        {
            TaskItemListView taskItemListView = _taskManagementController.GetTaskItemById(id);
            Id = taskItemListView.Id;
            Title = taskItemListView.Title;
            Description = taskItemListView.Description!;
            Category = taskItemListView.Category;
            PriorityLevel = taskItemListView.PriorityLevel;
            TaskState = taskItemListView.TaskState;
            DueDate = taskItemListView.DueDate;
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        _isNew = true;

        ClearFields();
        EnabledFields();

        rdbInProgress.Enabled = false;
        rdbDone.Enabled = false;
        btnNew.Enabled = false;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
    }

    private void ClearFields()
    {
        txtId.Clear();
        txtTitle.Clear();
        txtDescription.Clear();
        rdbToDo.Checked = true;
        cbbCategory.SelectedIndex = 0;
    }

    private void EnabledFields()
    {
        btnSave.Enabled = true;

        txtTitle.Enabled = true;
        txtDescription.Enabled = true;
        cbbCategory.Enabled = true;
        dtpDueDate.Enabled = true;
        rdbNormal.Enabled = true;
        rdbUrgent.Enabled = true;
        rdbToDo.Enabled = true;
        rdbInProgress.Enabled = true;
        rdbDone.Enabled = true;
        txtTitle.Focus();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (listTaksItems.Items.Count == 0)
        {
            MessageBox.Show("No se han agredado tareas", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _isNew = false;

        EnabledFields();

        btnUpdate.Enabled = false;
        btnNew.Enabled = false;
        btnDelete.Enabled = false;
    }

    private void DisabledFields()
    {
        btnNew.Enabled = true;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;

        btnSave.Enabled = false;

        txtTitle.Enabled = false;
        txtDescription.Enabled = false;
        cbbCategory.Enabled = false;
        dtpDueDate.Enabled = false;
        rdbNormal.Enabled = false;
        rdbUrgent.Enabled = false;
        rdbToDo.Enabled = false;
        rdbInProgress.Enabled = false;
        rdbDone.Enabled = false;

        btnNew.Focus();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if ((listTaksItems.SelectedItems.Count == 0))
        {
            MessageBox.Show("No ha seleccionado una tarea", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            _taskManagementController.DeleteTask(new TaskItemRemoveView() { Id = Id });
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        finally
        {
            if (listTaksItems.Items.Count > 0)
            {
                DisplayTaskByPriorityAndDueDate();
            }

            DisplayTaskActionHistory();
        }
    }

    private void DisplayTaskActionHistory()
    {
        listTaskHistoryStack.Items.Clear();

        try
        {
            var taskActionsHistory = _taskManagementController.TaskActionsHistory;
            if (!taskActionsHistory.Any())
            {
                MessageBox.Show("No se ha creado tarea", "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var taskItem in taskActionsHistory)
            {
                listTaskHistoryStack.Items.Add(new ListViewItem(new[]
                {
                    taskItem.Id.ToString(),
                    taskItem.Title,
                    taskItem.ActionOnTask.GetMesage()
                }));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}