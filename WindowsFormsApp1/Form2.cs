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
        public Form2(BindingList<Student> incomingList)
        {
            InitializeComponent();


            dataGridView1.DataSource = incomingList;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
