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
        {

            InitializeComponent();

            #region  The way I tried
            /*
            DataGridView row1 = new DataGridView();
            AgnosticDatabaseManager mng = new AgnosticDatabaseManager();
            List<StudentInfo> lst = mng.ExtractData();
            DataColumn col = new DataColumn();
            DataTable dt = new DataTable();


            int numStudents = lst.Count;





            //row.Rows.Add("Student First Name: ",lst[0].FirstName);
           
            row.RowCount = 4;
            lbTest.Items.Add(row1.ColumnCount);
            lbTest.Items.Add(row1.RowCount);
            //lbTest.Items.Add();             

            for (int i = 0; i < row1.RowCount; i++)
            {
                this.row1.Rows.Add(lst[i].FirstName + lst[i].LastName);
                
            }


            // row.DataSource = lst[i].FirstName;
            //for (int i = 0; i < numStudents; i++)
            //{
            //    lbTest.Items.Add("ID: " + lst[i].ID);
            //    lbTest.Items.Add("First Name: " + lst[i].FirstName);
            //    lbTest.Items.Add("Last Name: " + lst[i].LastName); 

            ////row1.Columns.Add(lst[i].FirstName);
            // }


            */
            #endregion


            #region In Class

            AgnosticDatabaseManager mng = new AgnosticDatabaseManager();
            List<StudentInfo> lst = mng.ExtractData();

            int numStudent = lst.Count;
                for(int i = 0; i < numStudent; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //DataGridViewColumn col = new DataGridViewColumn();

                    DataGridViewTextBoxCell[] cells = new DataGridViewTextBoxCell[3];
                    
                    for (int columb_ind = 0; columb_ind < 3; columb_ind++)
                    {
                        cells[columb_ind] = new DataGridViewTextBoxCell();
                        cells[columb_ind].Value = lst[i][columb_ind];
                        row.Cells.Add(cells[columb_ind]);
                    }
                    dataGridView1.Rows.Add(row);


                    lbTest.Hide();
                    row1.Hide();

                #region
                /*
                DataGridViewComboBoxCell cbCell = new DataGridViewComboBoxCell();
                if(j == 0)
                cbCell.Value = lst[i].ID.ToString();
                cbCell.Value = lst[i].FirstName;
                row.Cells.Add(cbCell);

                if(j==1)
                DataGridViewComboBoxCell cbCell2 = new DataGridViewComboBoxCell();
                cbCell2.Value = lst[i].FirstName.ToString();
                row.Cells.Add(cbCell2);
                
                DataGridViewComboBoxCell cbCell3 = new DataGridViewComboBoxCell();
                cbCell3.Value = lst[i].FirstName.ToString();
                row.Cells.Add(cbCell3); 
                */
                #endregion
            }

            #endregion



        }
    }
}
