﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace XMLparse
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadEmployees();
		}
		private void LoadEmployees()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("EmployeeData.xml");

			foreach(XmlNode node in doc.DocumentElement)
			{
				string name = node.Attributes[0].Value;
				int age = int.Parse(node["Age"].InnerText);
				bool isMale = bool.Parse(node["IsMale"].InnerText);
				listBox1.Items.Add(new Employee(name, age, isMale));

			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		   if(listBox1.SelectedIndex !=-1)
			{
				propertyGrid1.SelectedObject = listBox1.SelectedItem;
			}
		}
	}
}
