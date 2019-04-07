using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace XMLserialization
{
	public class Class1
	{
		[XmlAttribute]
		public string Name { get; set; }
		public int Age { get; set; }
		public bool isMale { get; set; }
		public void Save(string fileName)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Create))
			{
				XmlSerializer XML = new XmlSerializer(typeof(Class1));
				XML.Serialize(fs, this);//serialize needs the file to write into and the object with is this.
			}
		}
	}
}
