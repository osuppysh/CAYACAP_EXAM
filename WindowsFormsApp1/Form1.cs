using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        BindingList<Student> studentList = new BindingList<Student>();
        string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Save the file path to our variable
                selectedImagePath = ofd.FileName;

                // Optional: Show the filename on a label so you know it worked
                // PathLabel.Text = ofd.SafeFileName;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {

            Student newStudent = new Student
            {
                FirstName = FirstNameBox.Text,
                MiddleName = MiddleNameBox.Text,
                LastName = LastNameBox.Text,
                Address = AddressBox.Text,
                Year = YearBox.Text,
                ImagePath = selectedImagePath,
                BirthDate = BirthDateBox.Value,

            }; string ImagePath = selectedImagePath;

            studentList.Add(newStudent);
            MessageBox.Show("Student Registered!");
            this.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
