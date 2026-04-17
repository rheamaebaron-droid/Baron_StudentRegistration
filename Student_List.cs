using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace baron_student2
{
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
        }

        private void Student_List_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView1.Rows.Clear();

            foreach (StudentObjects s in Main_Menu.students)
            {
                dataGridView1.Rows.Add(
                    s.FirstName,
                    s.LastName,
                    s.Course
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
    

