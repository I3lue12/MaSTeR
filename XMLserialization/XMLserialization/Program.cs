using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLserialization
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 class1 = new Class1();
			class1.Name = "brendon";
			class1.Age = 29;
			class1.isMale = true;
			class1.Save("myfile.xml");
		}
	}
}
