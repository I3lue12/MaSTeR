using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ReadFileText
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnFindFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			DialogResult dr = new DialogResult();
			dr = ofd.ShowDialog();
			if(dr ==  DialogResult.OK)
			{
				lbViewFileContents.Items.Add(ofd.FileName);
				FileInfo fi = new FileInfo(ofd.FileName);
				using (FileStream fs = new File
					Stream(fi.FullName, FileMode.Open))
				{
					fs.Read()
				}
			}
		}
	}
}
