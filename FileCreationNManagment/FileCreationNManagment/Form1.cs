using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FileCreationNManagment 
{
    public partial class Form1 : Form 
    {
        protected string fileDir;
        protected string fileName;
        protected int minIncrement;
        protected int maxIncrement;
        DirectoryInfo oldDir;
        FileInfo[] oldFiles;
        

        public Form1()
        {
            InitializeComponent();
            button2.Text = "Clear";   
        }
        
        private void tbFilePath_TextChanged(object sender, EventArgs e)//when the correct file dir is enterd in
        {
            
            if (Directory.Exists(tbFilePath.Text))
            {
                DirectoryInfo d = new DirectoryInfo(tbFilePath.Text);
                DirectoryInfo[] subDirs = d.GetDirectories();
                FileInfo[] files = d.GetFiles();

                fileDir = tbFilePath.Text;

                lbViewFiles.Items.Add("Directories");
                foreach (DirectoryInfo dir in subDirs)
                {
                    lbViewFiles.Items.Add(dir.FullName);
                }
                lbViewFiles.Items.Add("Files");
                foreach (FileInfo f in files)
                {
                    lbViewFiles.Items.Add(f.FullName);
                }
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            button2.Text = "Clear";
            lbViewFiles.Items.Clear();
        }
        //TODO: SelectedToGoToClip()
        private void SelectedToGoToClip(object sender, EventArgs e)
        {
          //clicked text copy to clipboard    
        }
       
        private void btn_createNewFile(object sender, EventArgs e)//button to change the filename
        {
            RenameFiles(fileDir, fileName);  //function that takes all information on page
        }

        private void RenameFiles(string filePath, string fileName)
        {
              

            if (Directory.Exists(filePath))//I do want to make sure that a the directory exists.
            {
                //TODO: Make a Directory of the new filename.
                //copy those files in the list box list and add the string of the new file name
                oldDir = new DirectoryInfo(filePath);
                oldFiles = oldDir.GetFiles();

                foreach (FileInfo fi in oldFiles)
                {
                    lbViewFiles.Items.Add(fi.Name + " with ext: " + fi.Extension);
                }

            }    
           //TODO: check to make sure the files are not duplicates of that name
           //TODO: change those file names and add the incriment to it.
           //TODO: make an undo button
        }

        private void File_Name(object sender, EventArgs e) //makeing NEW file Name global.
        {
            fileName = tbFileName.Text;
        }

        private void Min_Incre(object sender, EventArgs e) //Min incriment global
        {             
            minIncrement = Convert.ToInt32(dudMin.Text);
        }

        private void Max_Incre(object sender, EventArgs e)//Max incriment global
        {
            maxIncrement = Convert.ToInt32(dudMax.Text);
        }

        private void btnOrginizeBySeason(object sender, EventArgs e) //orginize list of files in alphabeticle order.
        {
            

            lbViewFiles.Items.Clear();
            
            List<NameNum> sortByName = new List<NameNum>();
            List<int> orderNum = new List<int>();
            
            foreach (FileInfo f in oldFiles)
            {
                NameNum nn = new NameNum();
                nn.Name = f.Name;
                sortByName.Add(nn);
            }    
            foreach(NameNum nn in sortByName)//finding a number that corrosponds with each fiel
            {
                int start = -1, end = -1;
                for(int i = 0; i < nn.Name.Length; i++)
                {
                    if(IsANumber(nn.Name[i]))
                    {
                        start = i;
                        break;
                    }
                }
                end = start;
                bool alphaFound = false;
                if (start > -1)
                {
                    for (int i = start + 1; i < nn.Name.Length; i++)
                    {
                        if (!IsANumber(nn.Name[i]))
                        {
                            end = i - 1;
                            alphaFound = true;
                            break;
                        }
                    }
                    if (!alphaFound)
                    {
                        end = nn.Name.Length - 1;
                    }

                    string numAsString = nn.Name.Substring(start, end - start + 1);
                    int num = Convert.ToInt32(numAsString);
                    nn.Number = num;

                    orderNum.Add(nn.Number); 
                }
                
            }
            orderNum.Sort();

            foreach (int n in orderNum)
            {
                foreach (NameNum m in sortByName)
                {
                    if (m.Number == n)
                    {
                        lbViewFiles.Items.Add(m.Name);
                        break;
                    }                      
                } 
            }             
        }

        private bool IsANumber(char c)
        {
            return (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9');
        }

        private void btnDateOrgin_Click(object sender, EventArgs e)
        {
            //TODO: make the list box items in order by date

            List<NameNum> orderByDate = new List<NameNum>();
            foreach(FileInfo f in oldFiles)
            {
                NameNum nn = new NameNum();
                nn.Name = f.Name;
                nn.Date = f.LastAccessTime.Date;
                orderByDate.Add(nn);
            }
            lbViewFiles.Items.Clear();
            foreach(NameNum n in orderByDate)
            {
                
                lbViewFiles.Items.Add(n.Name + "-" + n.Date.ToString());
            }
            
        }

        private void Clear_File_path(object sender, EventArgs e) //onclick Clearing the file path text
        {
            if(tbFilePath.Text=="File Path")
                tbFilePath.Clear();
        }

        private void Clear_File_Name(object sender, EventArgs e)//clear file name text
        {
            if (tbFileName.Text == "File Name")
                tbFileName.Clear();
        }
    }
}
