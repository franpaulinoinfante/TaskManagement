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
        label1 = new Label();
        txtId = new TextBox();
        textBox2 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        textBox1 = new TextBox();
        dateTimePicker1 = new DateTimePicker();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        tabControl1 = new TabControl();
        tabList = new TabPage();
        tabStack = new TabPage();
        comboBox1 = new ComboBox();
        label9 = new Label();
        comboBox2 = new ComboBox();
        radioButton5 = new RadioButton();
        radioButton6 = new RadioButton();
        tabQueue = new TabPage();
        tabTree = new TabPage();
        listView1 = new ListView();
        listView2 = new ListView();
        listView3 = new ListView();
        button1 = new Button();
        button2 = new Button();
        label8 = new Label();
        label10 = new Label();
        tabControl1.SuspendLayout();
        tabList.SuspendLayout();
        tabStack.SuspendLayout();
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
        // textBox2
        // 
        textBox2.Location = new Point(176, 12);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(544, 27);
        textBox2.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(118, 15);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 4;
        label2.Text = "Título:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(12, 129);
        label3.Name = "label3";
        label3.Size = new Size(93, 20);
        label3.TabIndex = 5;
        label3.Text = "Descripción:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(335, 85);
        label4.Name = "label4";
        label4.Size = new Size(58, 20);
        label4.TabIndex = 6;
        label4.Text = "Estado:";
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
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(478, 48);
        label6.Name = "label6";
        label6.Size = new Size(73, 20);
        label6.TabIndex = 8;
        label6.Text = "Prioridad";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.Location = new Point(12, 79);
        label7.Name = "label7";
        label7.Size = new Size(98, 40);
        label7.TabIndex = 9;
        label7.Text = "Fecha de \r\nVencimiento:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 152);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ScrollBars = ScrollBars.Vertical;
        textBox1.Size = new Size(708, 65);
        textBox1.TabIndex = 10;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(116, 82);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(200, 27);
        dateTimePicker1.TabIndex = 12;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(400, 85);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(91, 24);
        radioButton1.TabIndex = 13;
        radioButton1.TabStop = true;
        radioButton1.Text = "Por Hacer";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(494, 85);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(106, 24);
        radioButton2.TabIndex = 14;
        radioButton2.TabStop = true;
        radioButton2.Text = "En Progreso";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(601, 85);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(97, 24);
        radioButton3.TabIndex = 15;
        radioButton3.TabStop = true;
        radioButton3.Text = "Terminada";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabList);
        tabControl1.Controls.Add(tabStack);
        tabControl1.Controls.Add(tabQueue);
        tabControl1.Controls.Add(tabTree);
        tabControl1.Dock = DockStyle.Bottom;
        tabControl1.Location = new Point(0, 280);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(732, 377);
        tabControl1.TabIndex = 17;
        // 
        // tabList
        // 
        tabList.Controls.Add(listView1);
        tabList.Location = new Point(4, 29);
        tabList.Name = "tabList";
        tabList.Padding = new Padding(3);
        tabList.Size = new Size(724, 344);
        tabList.TabIndex = 0;
        tabList.Text = "Lista";
        tabList.UseVisualStyleBackColor = true;
        // 
        // tabStack
        // 
        tabStack.Controls.Add(label10);
        tabStack.Controls.Add(label8);
        tabStack.Controls.Add(button2);
        tabStack.Controls.Add(button1);
        tabStack.Controls.Add(listView3);
        tabStack.Controls.Add(listView2);
        tabStack.Location = new Point(4, 29);
        tabStack.Name = "tabStack";
        tabStack.Padding = new Padding(3);
        tabStack.Size = new Size(724, 344);
        tabStack.TabIndex = 1;
        tabStack.Text = "Stack";
        tabStack.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(97, 45);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 28);
        comboBox1.TabIndex = 18;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label9.Location = new Point(224, 48);
        label9.Name = "label9";
        label9.Size = new Size(109, 20);
        label9.TabIndex = 20;
        label9.Text = "Sub-categoria:";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(339, 45);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(121, 28);
        comboBox2.TabIndex = 21;
        // 
        // radioButton5
        // 
        radioButton5.AutoSize = true;
        radioButton5.Location = new Point(557, 45);
        radioButton5.Name = "radioButton5";
        radioButton5.Size = new Size(77, 24);
        radioButton5.TabIndex = 22;
        radioButton5.TabStop = true;
        radioButton5.Text = "Normal";
        radioButton5.UseVisualStyleBackColor = true;
        // 
        // radioButton6
        // 
        radioButton6.AutoSize = true;
        radioButton6.Location = new Point(640, 46);
        radioButton6.Name = "radioButton6";
        radioButton6.Size = new Size(80, 24);
        radioButton6.TabIndex = 23;
        radioButton6.TabStop = true;
        radioButton6.Text = "Urgente";
        radioButton6.UseVisualStyleBackColor = true;
        // 
        // tabQueue
        // 
        tabQueue.Location = new Point(4, 29);
        tabQueue.Name = "tabQueue";
        tabQueue.Padding = new Padding(3);
        tabQueue.Size = new Size(724, 344);
        tabQueue.TabIndex = 2;
        tabQueue.Text = "Queue";
        tabQueue.UseVisualStyleBackColor = true;
        // 
        // tabTree
        // 
        tabTree.Location = new Point(4, 29);
        tabTree.Name = "tabTree";
        tabTree.Padding = new Padding(3);
        tabTree.Size = new Size(724, 333);
        tabTree.TabIndex = 3;
        tabTree.Text = "Tree";
        tabTree.UseVisualStyleBackColor = true;
        // 
        // listView1
        // 
        listView1.Dock = DockStyle.Fill;
        listView1.Location = new Point(3, 3);
        listView1.Name = "listView1";
        listView1.Size = new Size(718, 338);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // listView2
        // 
        listView2.Location = new Point(8, 40);
        listView2.Name = "listView2";
        listView2.Size = new Size(197, 298);
        listView2.TabIndex = 0;
        listView2.UseCompatibleStateImageBehavior = false;
        // 
        // listView3
        // 
        listView3.Location = new Point(519, 43);
        listView3.Name = "listView3";
        listView3.Size = new Size(197, 298);
        listView3.TabIndex = 1;
        listView3.UseCompatibleStateImageBehavior = false;
        // 
        // button1
        // 
        button1.Location = new Point(263, 71);
        button1.Name = "button1";
        button1.Size = new Size(208, 54);
        button1.TabIndex = 2;
        button1.Text = "Undo";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(263, 180);
        button2.Name = "button2";
        button2.Size = new Size(208, 54);
        button2.TabIndex = 3;
        button2.Text = "Redo";
        button2.UseVisualStyleBackColor = true;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label8.Location = new Point(61, 17);
        label8.Name = "label8";
        label8.Size = new Size(59, 20);
        label8.TabIndex = 24;
        label8.Text = "History";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label10.Location = new Point(586, 17);
        label10.Name = "label10";
        label10.Size = new Size(50, 20);
        label10.TabIndex = 25;
        label10.Text = "Redos";
        // 
        // TaskManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(732, 657);
        Controls.Add(radioButton6);
        Controls.Add(radioButton5);
        Controls.Add(comboBox2);
        Controls.Add(label9);
        Controls.Add(comboBox1);
        Controls.Add(tabControl1);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(dateTimePicker1);
        Controls.Add(textBox1);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(txtId);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 4, 3, 4);
        Name = "TaskManagementForm";
        Text = "TaskManagementForm";
        tabControl1.ResumeLayout(false);
        tabList.ResumeLayout(false);
        tabStack.ResumeLayout(false);
        tabStack.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private TextBox txtId;
    private TextBox textBox2;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox textBox1;
    private DateTimePicker dateTimePicker1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private TabControl tabControl1;
    private TabPage tabList;
    private TabPage tabStack;
    private ComboBox comboBox1;
    private Label label9;
    private ComboBox comboBox2;
    private RadioButton radioButton5;
    private RadioButton radioButton6;
    private TabPage tabQueue;
    private TabPage tabTree;
    private ListView listView1;
    private Label label10;
    private Label label8;
    private Button button2;
    private Button button1;
    private ListView listView3;
    private ListView listView2;
}