using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Baron_Project1
{
    public partial class Form4 : Form
    {
        public StudentObject? selectedStudent;
        public Form4(StudentObject student)
        {
            InitializeComponent();

            nameLabel.Text = $"{student.LastName}, {student.FirstName}";
            ageLabel.Text = $"{student.Age}";
            genderLabel.Text = $"{student.Gender}";
            courseLabel.Text = $"{student.Course}";
            yearLabel.Text = $"{student.Year}";
            addressLabel.Text = $"{student.Address}";
            birthDateLabel.Text = $"{student.Birthdate}";

            selectedStudent = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 editStudent = new Form2(selectedStudent!);
            editStudent.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public override bool Equals(object? obj)
        {
            return obj is Form4 form &&
                   EqualityComparer<StudentObject?>.Default.Equals(selectedStudent, form.selectedStudent);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(selectedStudent);
        }
    }
}