using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Week1
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }
        //new method 
        private double Perform_Operation(String operation)
            {
                double result = 0;
            //Convert cvt = new Convert();

            double i1 = Convert.ToDouble(m_button_multi.Text);//Convert is static , example of static
            double i2 = Convert.ToDouble(buttonAdd.Text);

            //Regex regex = new Regex();


            if(operation == "+")
            {
                result = i1 + i2;
            }
            if(operation == "*")
            {
                result = i1 * i2;
            }
                return result;
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
            #region
            /*
            String ControlType = sender.ToString();
            Button sender_button = (Button)sender; //we used sender
            String sign_clicked = sender_button.Text;
            if (sign_clicked == "+")
            {
                MessageBox.Show("added");
            }
            if (sign_clicked == "*")
            {
                MessageBox.Show("Multiplied");
            }
            */
            #endregion
            #region

            
            String ControlType = sender.ToString();
            MessageBox.Show(ControlType);
            if(ControlType.Contains("TextBox"))
            {
                TextBox box = (TextBox)sender;
                MessageBox.Show("you clicked a textbox");
            }
            else
            {
                Button btn = (Button)sender;
                MessageBox.Show("no textbox");
            }
            
            #endregion

        }
    }
}
