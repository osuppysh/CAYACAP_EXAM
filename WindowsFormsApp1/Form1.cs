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
        private Student studentToEdit = null;

        public static BindingList<Student> studentList = new BindingList<Student>();
        string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
            studentToEdit = null;

            if (GenderListBox.Items.Count > 0) GenderListBox.SelectedIndex = 0;
            if (CourseListBox.Items.Count > 0) CourseListBox.SelectedIndex = 0;
        }

        public Form1(Student existingStudent)
        {
            InitializeComponent();


            studentToEdit = existingStudent;

            FirstNameBox.Text = existingStudent.FirstName;
            LastNameBox.Text = existingStudent.LastName;
            YearBox.Text = existingStudent.Year;
            MiddleNameBox.Text = existingStudent.MiddleName;
            AddressBox.Text = existingStudent.Address;
            BirthDateBox.Value = existingStudent.BirthDate;

            GenderListBox.SelectedItem = existingStudent.Gender;
            CourseListBox.SelectedItem = existingStudent.Course;

            Save.Text = "Update"; // change button text
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
                // set file path into variable, path is more or less the image 
                selectedImagePath = ofd.FileName;


            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (studentToEdit != null)
            {
                // update existing student
                studentToEdit.FirstName = FirstNameBox.Text;
                studentToEdit.MiddleName = MiddleNameBox.Text;
                studentToEdit.LastName = LastNameBox.Text;
                studentToEdit.Address = AddressBox.Text;
                studentToEdit.BirthDate = BirthDateBox.Value;
                studentToEdit.Year = YearBox.Text;
                studentToEdit.Gender = GenderListBox.GetItemText(GenderListBox.SelectedItem);
                studentToEdit.Course = CourseListBox.GetItemText(CourseListBox.SelectedItem);

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    studentToEdit.ImagePath = selectedImagePath;
                }

                studentList.ResetBindings();
            }
            else
            {
                // create new stidemt
                Student newStudent = new Student
                {
                    FirstName = FirstNameBox.Text,
                    MiddleName = MiddleNameBox.Text,
                    LastName = LastNameBox.Text,
                    Address = AddressBox.Text,
                    Year = YearBox.Text,
                    ImagePath = selectedImagePath,
                    BirthDate = BirthDateBox.Value,
                    Gender = GenderListBox.GetItemText(GenderListBox.SelectedItem),
                    Course = CourseListBox.GetItemText(CourseListBox.SelectedItem),
                };

                studentList.Add(newStudent);
                MessageBox.Show("Student Registered!");
            }

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
