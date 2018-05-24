using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
namespace DataBaseIncorp
{
    public partial class AgnosticDatabaseManager
    {

        protected MySqlConnection SqlConnection;
        protected string currentErrorMessage;     
      
    }
}
