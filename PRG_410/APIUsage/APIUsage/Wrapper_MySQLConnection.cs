
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Wrapper_MySQLConnection : ISQLConnection
{

   
    public Wrapper_MySQLConnection()
    {
        mConnection = new MySQLConnection();
    }

   
    public MySQLConnection mConnection;

    
    public void Open()
    {
        mConnection.Open();
        // TODO implement here
    }

}