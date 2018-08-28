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
            //TODO: make a sub directory, copy file to new dir + new file name.  

            if (Directory.Exists(filePath))    //I do want to make sure that a the directory exists.
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

        private void btnNameOrgin_Click(object sender, EventArgs e) //orginize list of files in alphabeticle order.
        {
            //TODO: make the list box items in alphabeticle order

            lbViewFiles.Items.Clear();
            foreach (FileInfo f in oldFiles)
            {
                //search each files name
                string sf = f.Name;
                for(int i = 0; i < sf.Length; i++) //desired result have "name9" added then add "name10" then add "name11"
                {
                    for (int j = 0; j < 9; j++)//check for a number
                    {    //if(i == '1')...if(i+3 =='3')
                        if (i == j)
                        {
                            //rabbit hole.
                            //has to be an eaier way.
                            if (i + 1 == j) //plus one cause it is a 1 but I want the 1 next to it.
                            {
                                if (i + 2 == j) //hundreds
                                {
                                    //place that add file to list.
                                }
                            }
                        }
                    }
                    
                }

                lbViewFiles.Items.Add(f.Name);    
            }



            string h = oldFiles[0].Name;
            if(h[0] == 'a')
            {

            }

            //ArrayList oldViewFiles = new ArrayList();
            //oldViewFiles.Clear();
            //foreach(FileInfo f in oldFiles)
            //{
            //    oldViewFiles.Add(f);

            //}
            //oldViewFiles.Sort();
            //lbViewFiles.Items.Clear();
            //lbViewFiles.Items.Add(oldViewFiles);
        }

        private void btnDateOrgin_Click(object sender, EventArgs e)
        {
            //TODO: make the list box items in order by date

            //ArrayList oldDateFiles = new ArrayList();
            //oldDateFiles.Clear();
            //foreach (FileInfo f in oldFiles)
            //{
            //    oldDateFiles.Add(f);
            //}
            //oldDateFiles.Sort();
            //lbViewFiles.Items.Clear();
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
