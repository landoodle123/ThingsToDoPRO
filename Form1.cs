using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ThingsToDoPRO
{
    public partial class Form1 : Form
    {
        // Declare and initialize filePath correctly
        private readonly string filePath;
        private readonly string imagePath;

        public Form1()
        {
            InitializeComponent();

            // Set filePath to the path in the Documents folder
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "tasks.txt");
            imagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "background.txt");

            // Load tasks and background when the form loads
            LoadTasksFromFile();
            LoadBackgroundImage();

            // Start the timer to check due tasks
            dueDateTimer.Start();
        }
        private void CheckDueTasks(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            foreach (ListViewItem item in taskList.Items)
            {
                // Split the task text to get the due date and time
                string[] taskParts = item.Text.Split(new[] { " | Due " }, StringSplitOptions.None);

                if (taskParts.Length == 2)
                {
                    string dueDateString = taskParts[1];

                    // Parse the due date and time
                    if (DateTime.TryParse(dueDateString, out DateTime dueDateTime))
                    {
                        // Check if the task is due now or overdue and unchecked
                        if (!item.Checked && dueDateTime <= now)
                        {
                            // Show notification for the due task
                            notifyIcon1.BalloonTipTitle = "Task Due Reminder";
                            notifyIcon1.BalloonTipText = $"The task \"{taskParts[0]}\" is due now!";
                            notifyIcon1.ShowBalloonTip(30000); // Show the notification for 30 seconds
                        }
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            string date = addDueDate.Value.ToShortDateString();
            string time = addDueTime.Value.ToShortTimeString();

            if (!string.IsNullOrEmpty(task) && (!string.IsNullOrEmpty(date)))
            {
                // Combine the date and time for saving and displaying
                string dueDateTime = $"{date} {time}";
                taskList.Items.Add($"{task} | Due {dueDateTime}");
                textBox1.Clear();

                // Save tasks after adding a new one
                SaveTasksToFile();
            }
            else
            {
                MessageBox.Show("Please enter a task and due date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle selection changes if needed
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && taskList.SelectedItems.Count > 0)
            {
                taskList.Items.Remove(taskList.SelectedItems[0]);
                SaveTasksToFile();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string task = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(task))
                {
                    taskList.Items.Add(task);
                    textBox1.Clear();
                    SaveTasksToFile();
                }
            }
        }

        private void SaveTasksToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in taskList.Items)
                {
                    string[] taskParts = item.Text.Split('|');
                    writer.WriteLine($"{taskParts[0].Trim()}|{item.Checked}|{taskParts[1].Trim()}"); // Save task, status, and due date/time
                }
            }
        }




        private void LoadTasksFromFile()
        {
            try
            {
                taskList.Items.Clear();
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 3)
                    {
                        ListViewItem item = new ListViewItem(parts[0].Trim())
                        {
                            Checked = bool.Parse(parts[1].Trim())
                        };
                        item.SubItems.Add($"| Due {parts[2].Trim()}");
                        taskList.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred loading the task list from the file: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void changeBackground_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog1.FileName;

                try
                {
                    this.BackgroundImage = Image.FromFile(selectedImagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;

                    // Save the path of the selected image
                    File.WriteAllText(imagePath, selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred setting the background image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBackgroundImage()
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    string loadedImagePath = File.ReadAllText(imagePath);
                    this.BackgroundImage = Image.FromFile(loadedImagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred loading the background image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksToFile();

            // Dispose of NotifyIcon
            notifyIcon1.Dispose();
        }


    }
}
