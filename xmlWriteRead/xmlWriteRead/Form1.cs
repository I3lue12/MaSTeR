using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace xmlWriteRead
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class CustomerData
		{
			public string ID;
			public string Name;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			WriteXML();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ReadXML();
		}


		private void WriteXML()
		{
			var customer = new CustomerData();
			customer.ID = textBox1.Text;
			customer.Name = textBox2.Text;

			var xs = new XmlSerializer(typeof(CustomerData));
			using (FileStream fs = new FileStream("TestXML", FileMode.Create))
			{
				xs.Serialize(fs, customer);
			}
		}

		private void ReadXML()
		{
			try
			{
				CustomerData customer = new CustomerData();
				var xs = new XmlSerializer(typeof(CustomerData));

				using (FileStream fd = new FileStream("TestXML", FileMode.Open))
				{
					customer = (CustomerData)xs.Deserialize(fd) ;	 //as CustomerData

					if (customer != null)
					{								
						textBox3.Text = customer.ID;  
						textBox4.Text = customer.Name;
					}
				}

			}
			catch (Exception)
			{

			}
			
		}
	}
}
