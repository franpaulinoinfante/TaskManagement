using System.ComponentModel;
using TaskManagement.Controllers;
using TaskManagement.TaskViews;
using TaskManagement.TaskViews.CategoryViews;
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
            return categories.FirstOrDefault(c => c.GetMesage() == cbbSubCategories.Text);
        }
        set
        {
            cbbSubCategories.SelectedItem = value.GetMesage();
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
    public TaskStates TaskStates
    {
        get
        {
            if (rdbToDo.Checked)
            {
                return Types.TaskStates.ToDo;
            }

            if (rdbInProgress.Checked)
            {
                return Types.TaskStates.InProgress;
            }

            return Types.TaskStates.Done;
        }
        set
        {
            switch (value)
            {
                case Types.TaskStates.ToDo:
                    rdbToDo.Checked = true;
                    break;
                case Types.TaskStates.InProgress:
                    rdbInProgress.Checked = true;
                    break;
                case Types.TaskStates.Done:
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
        listTaksItems.Columns.Add("Título", 310);
        listTaksItems.Columns.Add("Priodidad", 85);
        listTaksItems.Columns.Add("Estado", 100);
        listTaksItems.Columns.Add("Categoria", 175);
        listTaksItems.Columns.Add("Fecha Vencimiento", 160);

        listTaskActionsHistory.View = View.Details;
        listTaskActionsHistory.Columns.Add("Id", 50);
        listTaskActionsHistory.Columns.Add("Título", 150);
        listTaskActionsHistory.Columns.Add("Acción", 100);

        listTaskActionsRedos.View = View.Details;
        listTaskActionsRedos.Columns.Add("Id", 50);
        listTaskActionsRedos.Columns.Add("Título", 150);
        listTaskActionsRedos.Columns.Add("Acción", 100);

        listTaskUrgent.View = View.Details;
        listTaskUrgent.Columns.Add("Id", 50);
        listTaskUrgent.Columns.Add("Título", 310);
        listTaskUrgent.Columns.Add("Priodidad", 85);
        listTaskUrgent.Columns.Add("Estado", 100);
        listTaskUrgent.Columns.Add("Categoria", 175);
        listTaskUrgent.Columns.Add("Fecha Vencimiento", 160);
    }

    private void TaskManagementForm_Load(object sender, EventArgs e)
    {
        LoadCategories();

        if (listTaksItems.Items.Count > 0)
        {
            btnUpdate.Enabled = true;
        }
        //DisplayTaskByPriorityAndDueDate();

        if (_taskManagementController.AnyTask())
        {
            btnMarkTaskUrgent.Enabled = true;
        }

        cbbCategory.SelectedIndex = 0;

        DisplayCategoryTree();

        DisplayTaskUrgents();
    }

    private void DisplayCategoryTree()
    {
        tvCategory.Nodes.Clear();

        Category[] categoriasPrincipales = new[]
        {
            Category.Personal,
            Category.Work,
            Category.Studies,
            Category.Home,
            Category.Maintenance
        };

        Dictionary<Category, Category> jerarquiaCategorias = new Dictionary<Category, Category>
        {
            // Personal
            { Category.PersonalDevelopment, Category.Personal },
            { Category.GoalsAndPlanning, Category.Personal },
            { Category.SelfLearning, Category.Personal },
            { Category.JournalingAndReflections, Category.Personal },
            { Category.HabitsAndRoutines, Category.Personal },      

            // Work
            { Category.Meetings, Category.Work },
            { Category.Reports, Category.Work },
            { Category.SoftwareDevelopment, Category.Work },
            { Category.DataAnalysis, Category.Work },
            { Category.Presentations, Category.Work },      

            // Studies
            { Category.TasksAndProjects, Category.Studies },
            { Category.Exams, Category.Studies },
            { Category.PendingReadings, Category.Studies },
            { Category.ClassesAndCourses, Category.Studies },       

            // Home
            { Category.Cleaning, Category.Home },
            { Category.HouseholdShopping, Category.Home },
            { Category.UtilityPayments, Category.Home },        

            // Maintenance
            { Category.MedicalAppointments, Category.Maintenance },
            { Category.Exercise, Category.Maintenance },
            { Category.Nutrition, Category.Maintenance },
            { Category.Rest, Category.Maintenance }
        };

        // Crear nodos raíz para cada categoría principal
        Dictionary<Category, TreeNode> nodosPrincipales = categoriasPrincipales.ToDictionary(
            cat => cat,
            cat => tvCategory.Nodes.Add(cat.ToString())
        );

        // Agrupar tareas por subcategoría
        IEnumerable<IGrouping<Category, TaskItemListView>> tareasPorSubcategoria = _taskManagementController.TaskItemListViews
            .Where(t => jerarquiaCategorias.ContainsKey(t.Category))
            .GroupBy(t => t.Category);

        foreach (IGrouping<Category, TaskItemListView> grupo in tareasPorSubcategoria)
        {
            Category subcategoria = grupo.Key;
            Category categoriaPrincipal = jerarquiaCategorias[subcategoria];
            TreeNode nodoPadre = nodosPrincipales[categoriaPrincipal];

            // Crear nodo de subcategoría si no existe
            TreeNode nodoSubcategoria = nodoPadre.Nodes
                .Cast<TreeNode>()
                .FirstOrDefault(n => n.Text == subcategoria.GetMesage())
                ?? nodoPadre.Nodes.Add(subcategoria.GetMesage());

            // Agregar tareas a la subcategoría
            foreach (TaskItemListView? tarea in grupo)
            {
                nodoSubcategoria.Nodes.Add($"{tarea.Id} - {tarea.Title} - {tarea.TaskStates.GetMesage()} - {tarea.PriorityLevel.GetMesage()} - {tarea.DueDate}");
            }
        }

        tvCategory.ExpandAll();
    }

    private void LoadCategories()
    {
        cbbCategory.DataSource = MainCategory.GetCategories;

        //foreach (Category item in Enum.GetValues<Types.Category>())
        //{
        //    cbbCategory.Items.Add(item.GetMesage());
        //}

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
                        TaskStates = this.TaskStates,
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
                        TaskStates = TaskStates,
                        Category = Category,
                        PriorityLevel = PriorityLevel,
                        DueDate = DueDate
                    });

                    listTaksItems.FullRowSelect = true;
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
        }

        DisplayTaskByPriorityAndDueDate();
        DisplayTaskActionHistory();
        DisplayTaskRepos();
        DisplayCategoryTree();
        SetValueToFields(listTaksItems.Items.Count);

    }

    private bool IsValidFields()
    {
        if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Description) || (DueDate < DateTime.Today))
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
            foreach (TaskItemListView taskItem in _taskManagementController.TaskItemListViews)
            {
                listTaksItems.Items.Add(new ListViewItem(new[]
                {
                    taskItem.Id.ToString(),
                    taskItem.Title,
                    taskItem.PriorityLevel.GetMesage(),
                    taskItem.TaskStates.GetMesage(),
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
            TaskStates = taskItemListView.TaskStates;
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
        btnMarkTaskUrgent.Enabled = false;
    }

    private void ClearFields()
    {
        txtId.Clear();
        txtTitle.Clear();
        txtDescription.Clear();
        rdbToDo.Checked = true;
        rdbNormal.Checked = true;
        cbbCategory.SelectedIndex = 0;

        cbbSubCategories.Enabled = true;
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

        tabControl1.SelectedTab = tabList;

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
        btnMarkTaskUrgent.Enabled = false;

        listTaksItems.FullRowSelect = false;
    }

    private void DisabledFields()
    {
        btnNew.Enabled = true;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;
        btnMarkTaskUrgent.Enabled = true;

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
        if (listTaksItems.SelectedItems.Count == 0)
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
        listTaskActionsHistory.Items.Clear();

        try
        {
            foreach (TaskActionsHistoryView taskItem in _taskManagementController.TaskActionsHistory)
            {
                listTaskActionsHistory.Items.Add(new ListViewItem(new[]
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

    private void btnUndo_Click(object sender, EventArgs e)
    {
        try
        {
            _taskManagementController.Undo();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            DisplayTaskByPriorityAndDueDate();
            DisplayTaskActionHistory();
            DisplayTaskRepos();
        }
    }

    private void DisplayTaskRepos()
    {
        listTaskActionsRedos.Items.Clear();

        try
        {
            IReadOnlyList<TaskActionsRedoView> taskActionsRedos = _taskManagementController.TaskActionsRedos;
            if (taskActionsRedos.Any())
            {
                foreach (TaskActionsRedoView taskRepos in taskActionsRedos)
                {
                    listTaskActionsRedos.Items.Add(new ListViewItem(new[]
                    {
                    taskRepos.Id.ToString(),
                    taskRepos.Title,
                    taskRepos.ActionOnTask.GetMesage()
                }));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Información!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    private void btnRedo_Click(object sender, EventArgs e)
    {
        try
        {
            _taskManagementController.Redo();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            DisplayTaskByPriorityAndDueDate();
            DisplayTaskActionHistory();
            DisplayTaskRepos();
        }
    }

    private void btnMarkTaskUrgent_Click(object sender, EventArgs e)
    {
        if (listTaksItems.Items.Count == 0)
        {
            MessageBox.Show("La lista de tarea esta vacia", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (listTaksItems.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar una tarea", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            _taskManagementController.MarkTaskUrgent(new UpdatePriorityLevel() { Id = Id, PriorityLevel = PriorityLevel.Urgent });
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            DisplayTaskByPriorityAndDueDate();
            DisplayTaskActionHistory();
            DisplayTaskRepos();
            DisplayTaskUrgents();

            tabControl1.SelectedTab = tabQueue;
        }
    }

    private void DisplayTaskUrgents()
    {
        listTaskUrgent.Items.Clear();
        try
        {
            IReadOnlyList<TaskUrgentsView> taskUrgents = _taskManagementController.TaskItemUrgents;
            foreach (TaskUrgentsView taskUrgent in taskUrgents)
            {
                listTaskUrgent.Items.Add(new ListViewItem(new[]
                {
                    taskUrgent.Id.ToString(),
                    taskUrgent.Title,
                    taskUrgent.PriorityLevel.GetMesage(),
                    taskUrgent.TaskStates.GetMesage(),
                    taskUrgent.Category.ToString(),
                    taskUrgent.DueDate.ToString()
                }));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnProcessTask_Click(object sender, EventArgs e)
    {
        //if (listTaksItems.Items.Count == 0)
        //{
        //    MessageBox.Show("No existen tareas", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        try
        {
            _taskManagementController.ProcessUrgentTask();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            DisplayTaskByPriorityAndDueDate();
            DisplayTaskActionHistory();
            DisplayTaskRepos();
            DisplayTaskUrgents();
        }
    }

    private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        cbbSubCategories.Items.Clear();

        if (cbbCategory.SelectedItem is Category selectedCategory)
        {
            if (SubCategories.SubCategoriesDic.TryGetValue(selectedCategory, out Category[]? subCategories))
            {
                foreach (var item in subCategories)
                {
                    cbbSubCategories.Items.Add(item.GetMesage());
                }
            }
            else
            {
                cbbSubCategories.DataSource = null;
            }
        }
    }
}