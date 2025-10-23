using ToDoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        TaskManager m = new TaskManager();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = i + 1;
            i++;
            TaskItem task = new TaskItem(id, txtTitle.Text, txtDesc.Text, dtpduedate.Value);
            m.AddTask(task);
            MessageBox.Show("Task Added Successfuly");
            ShowTasks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowTasks()
        {
            listTasks.Items.Clear();
            List<TaskItem> allTasks = m.GetAllTasks();
            foreach (TaskItem t in allTasks)
            {
                string status = "";
                if (t.IsCompleted == true)
                {
                    status = "[Done]";
                }
                else
                {
                    status = "[Pending]";
                }

                string info = t.TaskId + ": " + t.Title + " " + status + " - " + t.DueDate.ToShortDateString();
                listTasks.Items.Add(info);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to update.");
                return;
            }

            int id = listTasks.SelectedIndex + 1;
            TaskItem updatedTask = new TaskItem(id, txtTitle.Text, txtDesc.Text, dtpduedate.Value);

            m.UpdateTask(id, updatedTask);
            MessageBox.Show("Task updated successfully!");
            ShowTasks();
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int id = listTasks.SelectedIndex + 1;
            m.DeleteTask(id);
            MessageBox.Show("Task deleted successfully!");
            ShowTasks();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to mark as completed.");
                return;
            }

            int id = listTasks.SelectedIndex + 1;
            m.MarkAsCompleted(id);
            MessageBox.Show("Task marked as completed!");
            ShowTasks();
        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            ShowTasks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
