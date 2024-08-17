namespace ThingsToDoPRO
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            addTask = new Button();
            clearButton = new Button();
            taskList = new ListView();
            deleteSelected = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // addTask
            // 
            addTask.Location = new Point(286, 10);
            addTask.Name = "addTask";
            addTask.Size = new Size(81, 23);
            addTask.TabIndex = 1;
            addTask.Text = "Add Task";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += button1_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(8, 395);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(80, 29);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // taskList
            // 
            taskList.CheckBoxes = true;
            taskList.Location = new Point(8, 39);
            taskList.Name = "taskList";
            taskList.Size = new Size(359, 350);
            taskList.TabIndex = 1;
            taskList.UseCompatibleStateImageBehavior = false;
            taskList.View = View.List;
            taskList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // deleteSelected
            // 
            deleteSelected.Location = new Point(94, 395);
            deleteSelected.Name = "deleteSelected";
            deleteSelected.Size = new Size(80, 29);
            deleteSelected.TabIndex = 4;
            deleteSelected.Text = "Delete Task";
            deleteSelected.UseVisualStyleBackColor = true;
            deleteSelected.Click += deleteSelected_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(deleteSelected);
            Controls.Add(taskList);
            Controls.Add(clearButton);
            Controls.Add(addTask);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ThingsToDoPRO";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Button addTask;
        private Button clearButton;
        private ListView taskList;
        private Button deleteSelected;
    }
}
