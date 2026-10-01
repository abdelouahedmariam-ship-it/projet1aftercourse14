using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1afterfinishingcourse14
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3( string id,string Name,string Email,string phone, string gender, string garde)
        {
            InitializeComponent();
            txtId.Text = id;
            txtName.Text = Name;
            txtEmail.Text = Email;
            txtGender.Text = gender;
            txtGrade.Text = garde;
            msktextBox.Text = phone;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("the student is in Edit Mode .Please Make your Changes and Click Update to Save Them ", "Edit Mode ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
           
        }
    }
}
