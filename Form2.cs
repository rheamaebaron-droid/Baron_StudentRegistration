using System;
using System.Windows.Forms;

namespace Baron_Project1
{
    public partial class Form2 : Form
    {
        public StudentObjects? editStudent = null;
       

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(StudentObjects student)
        {
            InitializeComponent();
            editStudent = student;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (editStudent == null)
            {
                StudentObjects s = new StudentObjects();

                s.FirstName = firstNameBox.Text;
                s.LastName = lastNameBox.Text;
                s.MiddleInitial = middleInitialBox.Text;
                s.Birthdate = bdDatePicker.Value;
                s.Gender = genderBox.Text;
                s.Address = addressBox.Text;
                s.Course = courseBox.Text;
                s.Year = yearBox.Text;

                Form1.students.Add(s);
            }
            else
            {
                editStudent.FirstName = firstNameBox.Text;
                editStudent.LastName = lastNameBox.Text;
                editStudent.MiddleInitial = middleInitialBox.Text;
                editStudent.Birthdate = bdDatePicker.Value;
                editStudent.Gender = genderBox.Text;
                editStudent.Address = addressBox.Text;
                editStudent.Course = courseBox.Text;
                editStudent.Year = yearBox.Text;
            }

            Form1.SaveToText();
            MessageBox.Show("Saved successfully!");
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (editStudent != null)
            {
                firstNameBox.Text = editStudent.FirstName;
                lastNameBox.Text = editStudent.LastName;
                middleInitialBox.Text = editStudent.MiddleInitial;
                bdDatePicker.Value = editStudent.Birthdate;
                genderBox.Text = editStudent.Gender;
                addressBox.Text = editStudent.Address;
                courseBox.Text = editStudent.Course;
                yearBox.Text = editStudent.Year;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
    }
}