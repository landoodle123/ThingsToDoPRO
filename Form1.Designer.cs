namespace ThingsToDoPRO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer dueDateTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DateTimePicker addDueTime; // Add this to your variables


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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            addTask = new Button();
            clearButton = new Button();
            taskList = new ListView();
            deleteSelected = new Button();
            changeBackground = new Button();
            openFileDialog1 = new OpenFileDialog();
            addDueDate = new DateTimePicker();
            dueDateTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            addDueTime = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // addTask
            // 
            addTask.Location = new Point(436, 14);
            addTask.Name = "addTask";
            addTask.Size = new Size(75, 23);
            addTask.TabIndex = 1;
            addTask.Text = "Add Task";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += button1_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 397);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // taskList
            // 
            taskList.CheckBoxes = true;
            taskList.Location = new Point(12, 41);
            taskList.Name = "taskList";
            taskList.Size = new Size(499, 350);
            taskList.TabIndex = 3;
            taskList.UseCompatibleStateImageBehavior = false;
            taskList.View = View.List;
            taskList.SelectedIndexChanged += taskList_SelectedIndexChanged;
            taskList.KeyDown += listView1_KeyDown;
            // 
            // deleteSelected
            // 
            deleteSelected.Location = new Point(93, 397);
            deleteSelected.Name = "deleteSelected";
            deleteSelected.Size = new Size(95, 23);
            deleteSelected.TabIndex = 4;
            deleteSelected.Text = "Delete Task";
            deleteSelected.UseVisualStyleBackColor = true;
            deleteSelected.Click += deleteSelected_Click;
            // 
            // changeBackground
            // 
            changeBackground.Location = new Point(388, 397);
            changeBackground.Name = "changeBackground";
            changeBackground.Size = new Size(123, 23);
            changeBackground.TabIndex = 5;
            changeBackground.Text = "Change Background";
            changeBackground.UseVisualStyleBackColor = true;
            changeBackground.Click += changeBackground_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // addDueDate
            // 
            addDueDate.Location = new Point(276, 12);
            addDueDate.Name = "addDueDate";
            addDueDate.Size = new Size(89, 23);
            addDueDate.TabIndex = 6;
            // 
            // dueDateTimer
            // 
            dueDateTimer.Interval = 60000;
            dueDateTimer.Tick += CheckDueTasks;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Visible = true;
            // 
            // addDueTime
            // 
            addDueTime.Format = DateTimePickerFormat.Time;
            addDueTime.Location = new Point(371, 14);
            addDueTime.Name = "addDueTime";
            addDueTime.ShowUpDown = true;
            addDueTime.Size = new Size(59, 23);
            addDueTime.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 432);
            Controls.Add(addDueTime);
            Controls.Add(addDueDate);
            Controls.Add(changeBackground);
            Controls.Add(deleteSelected);
            Controls.Add(taskList);
            Controls.Add(clearButton);
            Controls.Add(addTask);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ThingsToDoPRO";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DateTimePicker addDueDate;
    }
}
