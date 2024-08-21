using System;
using System.IO;
using System.Windows.Forms;

namespace ThingsToDoPRO
{
    public partial class Form1 : Form
    {
        // Declare filePath here
        private readonly string filePath = "C:/Program Files (x86)/Lando Products/ThingsToDoPRO/nodelete.txt";

        public Form1()
        {
            InitializeComponent();
            // Initialize filePath
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

            // Load tasks when the form loads
            LoadTasksFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                taskList.Items.Add(task);
                textBox1.Clear();

                // Save tasks after adding a new one
                SaveTasksToFile();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            taskList.Items.Clear();

            // Save the empty list to the file
            SaveTasksToFile();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                taskList.Items.Remove(taskList.SelectedItems[0]);

                // Save tasks after deleting one
                SaveTasksToFile();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes if needed
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle selection changes if needed
        }

        private void SaveTasksToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in taskList.Items)
                {
                    writer.WriteLine($"{item.Text}|{item.Checked}");
                }
            }
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                taskList.Items.Clear();
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 2)
                    {
                        ListViewItem item = new ListViewItem(parts[0])
                        {
                            Checked = bool.Parse(parts[1])
                        };
                        taskList.Items.Add(item);
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveTasksToFile(); // Save tasks when the form closes
        }
    }
}
