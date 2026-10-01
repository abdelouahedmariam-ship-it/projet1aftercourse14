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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0|| textBox2.Text.Length == 0|| textBox3.Text.Length == 0|| maskedTextBox1.Text.Length == 0|| comboBox1.Text.Length == 0||( radioButton1.Checked==false && radioButton2.Checked == false))
            {
                
                MessageBox.Show("please enter all information before to continuing ", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListViewItem item = new ListViewItem(textBox1.Text);

                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);
                item.SubItems.Add(maskedTextBox1.Text);
                

                if (radioButton1.Checked == true)
                {
                    item.SubItems.Add("Female");

                }
                else {
                    item.SubItems.Add("Male");
                }
                item.SubItems.Add(comboBox1.Text);
                listView1.Items.Add(item);

            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            number = form2.Numberofstudent;
            int j = 0;

            for (int i = listView1.Items.Count+1; i <= number; i++)
                {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add("person"+i.ToString());
                item.SubItems.Add("person" + i.ToString()+"@gmail.com");
                item.SubItems.Add("000000010000"+i.ToString());
                if (i%2 == 0)
                {
                    item.SubItems.Add("Female");

                }
                else
                {
                    item.SubItems.Add("Male");
                }
                
                item.SubItems.Add(comboBox1.Items[j].ToString());
                j++;
                listView1.Items.Add(item);

            }
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000, " Student Generated  ", " Student have been generated Successfully  ", ToolTipIcon.Info);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
               
                MessageBox.Show("Please select a student edit  ", "No student selected ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[2].Text;
                msktextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtGender.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtGrade.Text = listView1.SelectedItems[0].SubItems[5].Text;
                ListViewItem Item = listView1.SelectedItems[0];
                string Id = Item.SubItems[0].Text;
                string name = Item.SubItems[1].Text;
                string Email = Item.SubItems[2].Text;
                string phone = Item.SubItems[3].Text;
                string Gender = Item.SubItems[4].Text;
                string Grade = Item.SubItems[5].Text;

                Form3 fr3 = new Form3(Id, name, Email, phone, Gender, Grade);
                fr3.Show();
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to delete  ", "No student selected ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000, " deleted student ", " the student deleted Successfully ", ToolTipIcon.Info);

                listView1.SelectedItems[0].Remove();
               
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to Show Card   ", "No student selected ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {    
                
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[2].Text;
                msktextBox.Text= listView1.SelectedItems[0].SubItems[3].Text;
                txtGender.Text= listView1.SelectedItems[0].SubItems[4].Text;
                txtGrade.Text= listView1.SelectedItems[0].SubItems[5].Text;
                ListViewItem Item = listView1.SelectedItems[0];
                string Id = Item.SubItems[0].Text;
                string name = Item.SubItems[1].Text;
                string Email = Item.SubItems[2].Text;
                string phone = Item.SubItems[3].Text;
                string Gender = Item.SubItems[4].Text;
                string Grade = Item.SubItems[5].Text;

                Form3 fr3 = new Form3(Id,name,Email,phone,Gender,Grade);
                fr3.ShowDialog();

            }

        }

      
    }
    }

