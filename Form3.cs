using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Baron_Project1
{
    public partial class Form3 : Form
    {
        public StudentObject? selectedStudent;

        public Form3(StudentObject? selectedStudent)
        {
            this.selectedStudent = selectedStudent;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentObject selected = (StudentObject)dataGridView1.Rows[e.RowIndex].DataBoundItem!;

            selectedStudent = selected;

            Form2 editForm = new Form2(selected);
            editForm.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form1.students;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form1.students;
            dataGridView1.Columns["MiddleInitial"]?.Visible = false;
            dataGridView1.Columns["Birthdate"]?.Visible = false;
            dataGridView1.Columns["Gender"]?.Visible = false;
            dataGridView1.Columns["Address"]?.Visible = false;
            dataGridView1.Columns["Year"]?.Visible = false;
            dataGridView1.Columns["Age"]?.Visible = false;

            dataGridView1.Columns["FirstName"]?.HeaderText = "First Name";
            dataGridView1.Columns["LastName"]?.HeaderText = "Last Name";
            dataGridView1.Columns["Course"]?.HeaderText = "Course";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentObject selected = (StudentObject)dataGridView1.Rows[e.RowIndex].DataBoundItem!;

            Form4 viewForm = new Form4(selected);
            viewForm.ShowDialog();
        }
    }
}

