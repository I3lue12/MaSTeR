using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingTextFile
{
    class ConfigFileException : Exception
    {
        private ConfigFileException()//no way to create constructor without
        {

        }
      public ConfigFileException(string error_message):base(error_message)
        {

        }                          
    }
}
