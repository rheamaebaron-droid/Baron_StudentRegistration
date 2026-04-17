using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace baron_student2
{
    public partial class Student_Information : Form
    {
        private StudentObjects student;

        public Student_Information(StudentObjects selectedStudent)
        {
            InitializeComponent();
            student = selectedStudent;
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            if (student == null) return;

            textBox1.Text = $"{student.FirstName} {student.LastName}";

            textBox2.Text = student.Address;

            textBox3.Text = student.Age.ToString();

            comboBox2.Text = student.Gender;

            comboBox1.Text = student.Course;

            comboBox3.Text = student.Year;

            dateTimePicker1.Value = student.Birthdate;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (student == null) return;

            string[] nameParts = textBox1.Text.Split(' ');

            student.FirstName = nameParts.Length > 0 ? nameParts[0] : "";
            student.LastName = nameParts.Length > 1 ? nameParts[1] : "";

            student.Address = textBox2.Text;

            student.Gender = comboBox2.Text;
            student.Course = comboBox1.Text;
            student.Year = comboBox3.Text;

            student.Birthdate = dateTimePicker1.Value;

            Main_Menu.SaveToText();

            MessageBox.Show(
                "Student Information Updated Successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}