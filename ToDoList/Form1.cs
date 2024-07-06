using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBox.Text))
            {
                ListBox.Items.Add(TextBox.Text);
                TextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != -1)
            {
                ListBox.Items.RemoveAt(ListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
        private void buttonCompleteTask_Click(object sender, EventArgs e)
        {
            int index = ListBox.SelectedIndex;
            if (index != -1)
            {
                string task = ListBox.SelectedItem.ToString();
                ListBox.Items.RemoveAt(index);
                ListBox.Items.Insert(index, "COMPLETED - " + task);
            }
            else
            {
                MessageBox.Show("Please select a task to complete.");
            }
        }
    }
}
