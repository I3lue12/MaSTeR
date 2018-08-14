
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class API_SQL_Connection
{

    public API_SQL_Connection(ISQLConnection iConnection)
    {
        mISQLConnection = iConnection;
    }

    
    public ISQLConnection mISQLConnection;

    public void Open()
    {
        mISQLConnection.Open();
    }

}