using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_learning;
using System.IO;
namespace PRG322
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();

            DLL.DllRun();//contains console
            //form
        }
    }
}
