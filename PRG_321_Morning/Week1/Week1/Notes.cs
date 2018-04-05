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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Handle_Operation(object sender, EventArgs e)
        {
            //event handleing with 2 buttons
            #region
            /*
            //event handler on same button.
            Button sender_button = (Button)sender; //we used sender
            String sign_clicked = sender_button.Text;
            if(sign_clicked == "+")
            {
                MessageBox.Show("added");
            }
            if(sign_clicked == "*")
            {
                MessageBox.Show("Multiplied");
            }
            */
            #endregion

            String ControlType = sender.ToString();
            MessageBox.Show(ControlType);
            if(ControlType.Contains("TextBox"))
            {
                MessageBox.Show("you clicked a textbox");
            }
            else
            {
                MessageBox.Show("no textbox");
            }

        }
    }
}
