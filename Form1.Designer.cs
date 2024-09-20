namespace ThingsToDoPRO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTask = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListView();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.changeBackground = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(276, 12);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(75, 23);
            this.addTask.TabIndex = 1;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // taskList
            // 
            this.taskList.CheckBoxes = true;
            this.taskList.Location = new System.Drawing.Point(12, 41);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(339, 350);
            this.taskList.TabIndex = 3;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.List;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.taskList_SelectedIndexChanged);
            this.taskList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Location = new System.Drawing.Point(93, 397);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(95, 23);
            this.deleteSelected.TabIndex = 4;
            this.deleteSelected.Text = "Delete Task";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(228, 397);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(123, 23);
            this.changeBackground.TabIndex = 5;
            this.changeBackground.Text = "Change Background";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 432);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ThingsToDoPRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
