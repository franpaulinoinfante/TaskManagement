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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagementForm));
        label1 = new Label();
        txtId = new TextBox();
        txtTitle = new TextBox();
        label2 = new Label();
        label3 = new Label();
        label5 = new Label();
        label7 = new Label();
        txtDescription = new TextBox();
        dtpDueDate = new DateTimePicker();
        rdbToDo = new RadioButton();
        rdbInProgress = new RadioButton();
        rdbDone = new RadioButton();
        tabControl1 = new TabControl();
        tabList = new TabPage();
        listTaksItems = new ListView();
        tabStack = new TabPage();
        label10 = new Label();
        label8 = new Label();
        btnRedo = new Button();
        btnUndo = new Button();
        listTaskActionsRedos = new ListView();
        listTaskActionsHistory = new ListView();
        tabQueue = new TabPage();
        btnProcessTask = new Button();
        listTaskUrgent = new ListView();
        tabTree = new TabPage();
        cbbCategory = new ComboBox();
        rdbNormal = new RadioButton();
        rdbUrgent = new RadioButton();
        btnSave = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        button1 = new Button();
        btnMarkTaskUrgent = new Button();
        btnUpdate = new Button();
        btnNew = new Button();
        btnDelete = new Button();
        tabControl1.SuspendLayout();
        tabList.SuspendLayout();
        tabStack.SuspendLayout();
        tabQueue.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(26, 20);
        label1.TabIndex = 1;
        label1.Text = "Id:";
        // 
        // txtId
        // 
        txtId.Location = new Point(44, 12);
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Size = new Size(68, 27);
        txtId.TabIndex = 2;
        txtId.TextAlign = HorizontalAlignment.Center;
        // 
        // txtTitle
        // 
        txtTitle.Enabled = false;
        txtTitle.Location = new Point(180, 12);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(589, 27);
        txtTitle.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(122, 15);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 4;
        label2.Text = "Título:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(12, 81);
        label3.Name = "label3";
        label3.Size = new Size(93, 20);
        label3.TabIndex = 5;
        label3.Text = "Descripción:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label5.Location = new Point(12, 48);
        label5.Name = "label5";
        label5.Size = new Size(79, 20);
        label5.TabIndex = 7;
        label5.Text = "Categoria:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.Location = new Point(347, 48);
        label7.Name = "label7";
        label7.Size = new Size(163, 20);
        label7.TabIndex = 9;
        label7.Text = "Fecha de Vencimiento:";
        // 
        // txtDescription
        // 
        txtDescription.Enabled = false;
        txtDescription.Location = new Point(12, 104);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ScrollBars = ScrollBars.Vertical;
        txtDescription.Size = new Size(757, 68);
        txtDescription.TabIndex = 6;
        // 
        // dtpDueDate
        // 
        dtpDueDate.Enabled = false;
        dtpDueDate.Location = new Point(516, 43);
        dtpDueDate.Name = "dtpDueDate";
        dtpDueDate.Size = new Size(253, 27);
        dtpDueDate.TabIndex = 3;
        // 
        // rdbToDo
        // 
        rdbToDo.AutoSize = true;
        rdbToDo.Checked = true;
        rdbToDo.Enabled = false;
        rdbToDo.Location = new Point(6, 20);
        rdbToDo.Name = "rdbToDo";
        rdbToDo.Size = new Size(92, 24);
        rdbToDo.TabIndex = 13;
        rdbToDo.TabStop = true;
        rdbToDo.Text = "Pendiente";
        rdbToDo.UseVisualStyleBackColor = true;
        // 
        // rdbInProgress
        // 
        rdbInProgress.AutoSize = true;
        rdbInProgress.Enabled = false;
        rdbInProgress.Location = new Point(6, 53);
        rdbInProgress.Name = "rdbInProgress";
        rdbInProgress.Size = new Size(106, 24);
        rdbInProgress.TabIndex = 14;
        rdbInProgress.Text = "En Progreso";
        rdbInProgress.UseVisualStyleBackColor = true;
        // 
        // rdbDone
        // 
        rdbDone.AutoSize = true;
        rdbDone.Enabled = false;
        rdbDone.Location = new Point(6, 83);
        rdbDone.Name = "rdbDone";
        rdbDone.Size = new Size(92, 24);
        rdbDone.TabIndex = 15;
        rdbDone.Text = "Realizada";
        rdbDone.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabList);
        tabControl1.Controls.Add(tabStack);
        tabControl1.Controls.Add(tabQueue);
        tabControl1.Controls.Add(tabTree);
        tabControl1.Dock = DockStyle.Bottom;
        tabControl1.Location = new Point(0, 212);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(912, 431);
        tabControl1.TabIndex = 10;
        // 
        // tabList
        // 
        tabList.Controls.Add(listTaksItems);
        tabList.Location = new Point(4, 29);
        tabList.Name = "tabList";
        tabList.Padding = new Padding(3);
        tabList.Size = new Size(904, 398);
        tabList.TabIndex = 0;
        tabList.Text = "Lista";
        tabList.UseVisualStyleBackColor = true;
        // 
        // listTaksItems
        // 
        listTaksItems.Dock = DockStyle.Fill;
        listTaksItems.FullRowSelect = true;
        listTaksItems.Location = new Point(3, 3);
        listTaksItems.Name = "listTaksItems";
        listTaksItems.Size = new Size(898, 392);
        listTaksItems.TabIndex = 0;
        listTaksItems.UseCompatibleStateImageBehavior = false;
        listTaksItems.View = View.Details;
        listTaksItems.Click += listTaksItems_Click;
        // 
        // tabStack
        // 
        tabStack.Controls.Add(label10);
        tabStack.Controls.Add(label8);
        tabStack.Controls.Add(btnRedo);
        tabStack.Controls.Add(btnUndo);
        tabStack.Controls.Add(listTaskActionsRedos);
        tabStack.Controls.Add(listTaskActionsHistory);
        tabStack.Location = new Point(4, 24);
        tabStack.Name = "tabStack";
        tabStack.Padding = new Padding(3);
        tabStack.Size = new Size(904, 403);
        tabStack.TabIndex = 1;
        tabStack.Text = "Stack";
        tabStack.UseVisualStyleBackColor = true;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label10.Location = new Point(704, 3);
        label10.Name = "label10";
        label10.Size = new Size(50, 20);
        label10.TabIndex = 25;
        label10.Text = "Redos";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label8.Location = new Point(134, 3);
        label8.Name = "label8";
        label8.Size = new Size(59, 20);
        label8.TabIndex = 24;
        label8.Text = "History";
        // 
        // btnRedo
        // 
        btnRedo.Location = new Point(344, 180);
        btnRedo.Name = "btnRedo";
        btnRedo.Size = new Size(208, 54);
        btnRedo.TabIndex = 3;
        btnRedo.Text = "Redo";
        btnRedo.UseVisualStyleBackColor = true;
        btnRedo.Click += btnRedo_Click;
        // 
        // btnUndo
        // 
        btnUndo.Location = new Point(344, 72);
        btnUndo.Name = "btnUndo";
        btnUndo.Size = new Size(208, 54);
        btnUndo.TabIndex = 2;
        btnUndo.Text = "Undo";
        btnUndo.UseVisualStyleBackColor = true;
        btnUndo.Click += btnUndo_Click;
        // 
        // listTaskActionsRedos
        // 
        listTaskActionsRedos.Location = new Point(568, 26);
        listTaskActionsRedos.Name = "listTaskActionsRedos";
        listTaskActionsRedos.Size = new Size(321, 366);
        listTaskActionsRedos.TabIndex = 1;
        listTaskActionsRedos.UseCompatibleStateImageBehavior = false;
        // 
        // listTaskActionsHistory
        // 
        listTaskActionsHistory.FullRowSelect = true;
        listTaskActionsHistory.Location = new Point(6, 26);
        listTaskActionsHistory.Name = "listTaskActionsHistory";
        listTaskActionsHistory.Size = new Size(321, 364);
        listTaskActionsHistory.TabIndex = 0;
        listTaskActionsHistory.UseCompatibleStateImageBehavior = false;
        listTaskActionsHistory.View = View.Details;
        // 
        // tabQueue
        // 
        tabQueue.Controls.Add(btnProcessTask);
        tabQueue.Controls.Add(listTaskUrgent);
        tabQueue.Location = new Point(4, 29);
        tabQueue.Name = "tabQueue";
        tabQueue.Padding = new Padding(3);
        tabQueue.Size = new Size(904, 398);
        tabQueue.TabIndex = 2;
        tabQueue.Text = "Queue";
        tabQueue.UseVisualStyleBackColor = true;
        // 
        // btnProcessTask
        // 
        btnProcessTask.Location = new Point(395, 362);
        btnProcessTask.Name = "btnProcessTask";
        btnProcessTask.Size = new Size(75, 28);
        btnProcessTask.TabIndex = 11;
        btnProcessTask.Text = "Procesar";
        btnProcessTask.UseVisualStyleBackColor = true;
        btnProcessTask.Click += btnProcessTask_Click;
        // 
        // listTaskUrgent
        // 
        listTaskUrgent.Dock = DockStyle.Top;
        listTaskUrgent.FullRowSelect = true;
        listTaskUrgent.Location = new Point(3, 3);
        listTaskUrgent.Name = "listTaskUrgent";
        listTaskUrgent.Size = new Size(898, 353);
        listTaskUrgent.TabIndex = 1;
        listTaskUrgent.UseCompatibleStateImageBehavior = false;
        listTaskUrgent.View = View.Details;
        // 
        // tabTree
        // 
        tabTree.Location = new Point(4, 24);
        tabTree.Name = "tabTree";
        tabTree.Padding = new Padding(3);
        tabTree.Size = new Size(904, 403);
        tabTree.TabIndex = 3;
        tabTree.Text = "Tree";
        tabTree.UseVisualStyleBackColor = true;
        // 
        // cbbCategory
        // 
        cbbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cbbCategory.Enabled = false;
        cbbCategory.FormattingEnabled = true;
        cbbCategory.Location = new Point(97, 45);
        cbbCategory.Name = "cbbCategory";
        cbbCategory.Size = new Size(239, 28);
        cbbCategory.TabIndex = 2;
        // 
        // rdbNormal
        // 
        rdbNormal.AutoSize = true;
        rdbNormal.Checked = true;
        rdbNormal.Enabled = false;
        rdbNormal.Location = new Point(6, 26);
        rdbNormal.Name = "rdbNormal";
        rdbNormal.Size = new Size(77, 24);
        rdbNormal.TabIndex = 22;
        rdbNormal.TabStop = true;
        rdbNormal.Text = "Normal";
        rdbNormal.UseVisualStyleBackColor = true;
        // 
        // rdbUrgent
        // 
        rdbUrgent.AutoSize = true;
        rdbUrgent.Enabled = false;
        rdbUrgent.Location = new Point(6, 56);
        rdbUrgent.Name = "rdbUrgent";
        rdbUrgent.Size = new Size(80, 24);
        rdbUrgent.TabIndex = 23;
        rdbUrgent.Text = "Urgente";
        rdbUrgent.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(178, 178);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(75, 28);
        btnSave.TabIndex = 7;
        btnSave.Text = "Guardar";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rdbToDo);
        groupBox1.Controls.Add(rdbInProgress);
        groupBox1.Controls.Add(rdbDone);
        groupBox1.Location = new Point(775, 97);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(130, 109);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Estado";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(button1);
        groupBox2.Controls.Add(btnMarkTaskUrgent);
        groupBox2.Controls.Add(rdbNormal);
        groupBox2.Controls.Add(rdbUrgent);
        groupBox2.Location = new Point(775, 5);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(130, 89);
        groupBox2.TabIndex = 4;
        groupBox2.TabStop = false;
        groupBox2.Text = "Prioridad";
        // 
        // button1
        // 
        button1.Enabled = false;
        button1.Image = (Image)resources.GetObject("button1.Image");
        button1.Location = new Point(92, 19);
        button1.Name = "button1";
        button1.Size = new Size(34, 32);
        button1.TabIndex = 12;
        button1.UseVisualStyleBackColor = true;
        // 
        // btnMarkTaskUrgent
        // 
        btnMarkTaskUrgent.Enabled = false;
        btnMarkTaskUrgent.Image = (Image)resources.GetObject("btnMarkTaskUrgent.Image");
        btnMarkTaskUrgent.Location = new Point(92, 55);
        btnMarkTaskUrgent.Name = "btnMarkTaskUrgent";
        btnMarkTaskUrgent.Size = new Size(34, 31);
        btnMarkTaskUrgent.TabIndex = 11;
        btnMarkTaskUrgent.UseVisualStyleBackColor = true;
        btnMarkTaskUrgent.Click += btnMarkTaskUrgent_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Enabled = false;
        btnUpdate.Location = new Point(95, 178);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 28);
        btnUpdate.TabIndex = 8;
        btnUpdate.Text = "Editar";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnNew
        // 
        btnNew.Location = new Point(12, 178);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(75, 28);
        btnNew.TabIndex = 0;
        btnNew.Text = "Nuevo";
        btnNew.UseVisualStyleBackColor = true;
        btnNew.Click += btnNew_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(261, 178);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 28);
        btnDelete.TabIndex = 9;
        btnDelete.Text = "Eliminar";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // TaskManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(912, 643);
        Controls.Add(btnDelete);
        Controls.Add(btnNew);
        Controls.Add(btnUpdate);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(btnSave);
        Controls.Add(cbbCategory);
        Controls.Add(tabControl1);
        Controls.Add(dtpDueDate);
        Controls.Add(txtDescription);
        Controls.Add(label7);
        Controls.Add(label5);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtTitle);
        Controls.Add(txtId);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(921, 682);
        Name = "TaskManagementForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Task Management";
        Load += TaskManagementForm_Load;
        tabControl1.ResumeLayout(false);
        tabList.ResumeLayout(false);
        tabStack.ResumeLayout(false);
        tabStack.PerformLayout();
        tabQueue.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private TextBox txtId;
    private TextBox txtTitle;
    private Label label2;
    private Label label3;
    private Label label5;
    private Label label7;
    private TextBox txtDescription;
    private DateTimePicker dtpDueDate;
    private RadioButton rdbToDo;
    private RadioButton rdbInProgress;
    private RadioButton rdbDone;
    private TabControl tabControl1;
    private TabPage tabList;
    private TabPage tabStack;
    private ComboBox cbbCategory;
    private RadioButton rdbNormal;
    private RadioButton rdbUrgent;
    private TabPage tabQueue;
    private TabPage tabTree;
    private ListView listTaksItems;
    private Label label10;
    private Label label8;
    private Button btnRedo;
    private Button btnUndo;
    private ListView listTaskActionsRedos;
    private ListView listTaskActionsHistory;
    private Button btnSave;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Button btnUpdate;
    private Button btnNew;
    private Button btnDelete;
    private Button btnMarkTaskUrgent;
    private ListView listTaskUrgent;
    private Button button1;
    private Button btnProcessTask;
}