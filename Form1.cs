using System;
using System.IO;
using System.Windows.Forms;

namespace ThingsToDoPRO
{
    public partial class Form1 : Form
    {
        // Declare and initialize filePath correctly
        private readonly string filePath;

        public Form1()
        {
            InitializeComponent();

            // Set filePath to the path in the Documents folder
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "tasks.txt");

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
                    writer.WriteLine($"{item.Text}|{item.Checked}");
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred loading the tasklist from the file. If your tasklist is not supposed to be empty, please raise an issue on GitHub. Error code: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeBackground_Click(object sender, EventArgs e)
{
    // Initialize the OpenFileDialog variable
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
        // Set filter to display only image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

        // Show the dialog and check if the user selected a file
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Load the selected image
                Image selectedImage = Image.FromFile(openFileDialog.FileName);

                // Set the form's background image
                this.BackgroundImage = selectedImage;

                // Optional: Set layout to control how the image fits the form
                this.BackgroundImageLayout = ImageLayout.Stretch; // Other options: Tile, Center, Zoom, None

            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"An error occurred while setting the background image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
