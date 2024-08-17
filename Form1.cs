namespace ThingsToDoPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                taskList.Items.Add(task);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            taskList.Items.Clear();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                taskList.Items.Remove(taskList.SelectedItems[0]);
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
    }
}
