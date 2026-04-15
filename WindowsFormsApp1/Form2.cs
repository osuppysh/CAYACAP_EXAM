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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            dataGridView1.DataSource = Form1.studentList;

            // hide image para limpyo
            if (dataGridView1.Columns["ImagePath"] != null)
            {
                dataGridView1.Columns["ImagePath"].Visible = false;
            }

            // format birthdate
            if (dataGridView1.Columns["BirthDate"] != null)
            {
                dataGridView1.Columns["BirthDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            // so i dont have to scroll
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowStudentDetails(object sender, DataGridViewCellEventArgs e)
        {
            // so user cant click header
            if (e.RowIndex >= 0)
            {
                Student selectedStudent = (Student)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                Form3 details = new Form3(selectedStudent);
                details.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
