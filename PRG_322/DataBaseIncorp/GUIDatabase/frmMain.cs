using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseIncorp;

namespace GUIDatabase
{
    public partial class frmMain : Form
    {

        public frmMain()
        { InitializeComponent();


            DataGridView row = new DataGridView();
            AgnosticDatabaseManager mng = new AgnosticDatabaseManager();
            List<StudentInfo> lst = mng.ExtractData();
            DataColumn col = new DataColumn();
            DataTable dt = new DataTable();


            int numStudents = lst.Count;





            //row.Rows.Add("Student First Name: ",lst[0].FirstName);

           
            row.RowCount = 4;
            lbTest.Items.Add(row.ColumnCount);
            lbTest.Items.Add(row.RowCount);
            //lbTest.Items.Add();
           

            for (int i = 0; i < row.RowCount; i++)
            {
                this.row.Rows.Add(lst[i].FirstName + lst[i].LastName);
            }
            // row.DataSource = lst[i].FirstName;
            //for (int i = 0; i < numStudents; i++)
            //{
            //    lbTest.Items.Add("ID: " + lst[i].ID);
            //    lbTest.Items.Add("First Name: " + lst[i].FirstName);
            //    lbTest.Items.Add("Last Name: " + lst[i].LastName);


            ////row.Columns.Add(lst[i].FirstName);
            // }



        }
    }
}
