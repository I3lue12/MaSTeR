using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Assessment_One : Form
    {
        public Assessment_One()
        {
            InitializeComponent();
            
        }
        //Make menu with three options
        //pg 640 #1
        //user names, email, phone.
        //lets do multiple.
       
        

        private void displayInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayUserInfo.Text = "Name: "+userNameInput.Text + "\n" + "E-mail: " + userEmailInput.Text + "\n" + "Phone: " +userPhoneInput.Text;
        }

       

        public void InfoControl()
        {
           // string[] userInfo = { userName, userEmail, userPhone };
            
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            userNameInput.Hide();
            userEmailInput.Hide();
            userPhoneInput.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void clearInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userNameInput.Show();
            userEmailInput.Show();
            userPhoneInput.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            displayUserInfo.Text = "";
            userNameInput.Clear();
            userEmailInput.Clear();
            userPhoneInput.Clear();

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutDev(object sender, EventArgs e)
        {
            userNameInput.Hide();
            userEmailInput.Hide();
            userPhoneInput.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            savebtn.Hide();
            displayUserInfo.Font = new Font("Times New Roman", 45);
            displayUserInfo.Left = 100;
            displayUserInfo.Top = 30;
            displayUserInfo.BackColor = Color.Aqua;
            displayUserInfo.Text = "Created by Brendon Blau\nVersion 1.0.5.8.9.A";
           
        }
    }
}
