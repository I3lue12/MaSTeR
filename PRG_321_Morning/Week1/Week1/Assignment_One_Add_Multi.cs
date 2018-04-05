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
    public partial class Assignment_One_Add_Multi : Form
    {
        public double inp1, inpt2, sum;
        
        public Assignment_One_Add_Multi()
        {
            InitializeComponent();
            
        }

        private void m_button_multi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstInput.Text) || String.IsNullOrEmpty(secondInput.Text))
            {
                feedBack.Text = "Enter in numbers";
            }
            else
            {
                double parsed1, parsed2;
                if (!double.TryParse(firstInput.Text, out parsed1) || !double.TryParse(secondInput.Text, out parsed2))
                {
                    feedBack.Text = "You silly, you need to enter in a number.";
                }
                else
                {
                    inp1 = Convert.ToDouble(firstInput.Text);
                    inpt2 = Convert.ToDouble(secondInput.Text);
                    sum = inp1 * inpt2;
                    feedBack.Text = sum + " This is your total when multiplied";
                }
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(firstInput.Text)||String.IsNullOrEmpty(secondInput.Text))
            {
                feedBack.Text = "Enter in numbers";
            }
            else
            {
                double parsed1,parsed2;
                if (!double.TryParse(firstInput.Text, out parsed1)||!double.TryParse(secondInput.Text, out parsed2))
                {//should make it so that it is NOT a letter.
                    feedBack.Text = "You silly, you need to enter in a number.";
                }
                else
                {//means it is a number
                    inp1 = Convert.ToDouble(firstInput.Text);
                    inpt2 = Convert.ToDouble(secondInput.Text);

                    sum = inp1 + inpt2;

                    feedBack.Text = sum + " This is your total when added.";
                 }
            }
            

        }

        private void secondInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
