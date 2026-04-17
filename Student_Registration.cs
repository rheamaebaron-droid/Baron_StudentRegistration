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
    public partial class Student_Registration : Form
    {
        public StudentObjects? editStudent = null;

        public Student_Registration()
        {
            InitializeComponent();
        }

        public Student_Registration(StudentObjects student)
        {
            InitializeComponent();
            editStudent = student;
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {
            if (editStudent != null)
            {
                textBox1.Text = editStudent.FirstName;
                textBox2.Text = editStudent.LastName;
                textBox3.Text = editStudent.MiddleInitial;
                dateTimePicker1.Value = editStudent.Birthdate;
                comboBox2.Text = editStudent.Gender;
                textBox4.Text = editStudent.Address;
                comboBox1.Text = editStudent.Course;
                textBox5.Text = editStudent.Year;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");

            if (editStudent == null)
            {
                StudentObjects s = new StudentObjects
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    MiddleInitial = textBox3.Text,
                    Birthdate = dateTimePicker1.Value,
                    Gender = comboBox2.Text,
                    Address = textBox4.Text,
                    Course = comboBox1.Text,
                    Year = textBox5.Text
                };

                Main_Menu.students.Add(s);
            }
            else
            {
                editStudent.FirstName = textBox1.Text;
                editStudent.LastName = textBox2.Text;
                editStudent.MiddleInitial = textBox3.Text;
                editStudent.Birthdate = dateTimePicker1.Value;
                editStudent.Gender = comboBox2.Text;
                editStudent.Address = textBox4.Text;
                editStudent.Course = comboBox1.Text;
                editStudent.Year = textBox5.Text;
            }

            Main_Menu.SaveToText();

            MessageBox.Show("Successfully Saved!",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}