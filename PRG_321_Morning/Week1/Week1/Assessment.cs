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
    public partial class Assessment : Form
    {
        public Assessment()
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
        }

        private void clearInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userNameInput.Show();
            userEmailInput.Show();
            userPhoneInput.Show();
            userNameInput.Clear();
            userEmailInput.Clear();
            userPhoneInput.Clear();

        }
    }
}
