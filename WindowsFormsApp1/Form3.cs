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
    public partial class Form3 : Form
    {
        private Student currentStudent;
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
        
            //dont count if havent celebrated bday yet this year
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        public Form3(Student selectedStudent)
        {
            InitializeComponent();

            this.currentStudent = selectedStudent;
            txtFirstName.Text = $"{currentStudent.FirstName} {currentStudent.LastName}";
            txtAge.Text = CalculateAge(currentStudent.BirthDate).ToString(); 
            txtGender.Text = currentStudent.Gender;
            txtCourse.Text = currentStudent.Course;
            txtYear.Text = currentStudent.Year;
            txtAddress.Text = currentStudent.Address;



            if (!string.IsNullOrEmpty(selectedStudent.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(selectedStudent.ImagePath);
            }
        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // open form1
            Form1 editForm = new Form1(currentStudent);
            editForm.Show();

            this.Close();
        }
    }
}
