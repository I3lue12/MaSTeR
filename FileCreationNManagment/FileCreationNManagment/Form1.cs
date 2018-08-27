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
namespace FileCreationNManagment
{
    public partial class Form1 : Form
    {
        protected string fileDir;
        protected string fileName;
        protected int minIncrement;
        protected int maxIncrement;

        public Form1()
        {
            InitializeComponent();
            button2.Text = "Clear";
            
        }

        private void File_Path(object sender, DragEventArgs e)
        {      
        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
           /*function takes in file path, file name, minimum increment, 
            * and maximum increment. This function goes through the files in that 
            * directory and changes the name of them incrimenting each time.
            */ 
            RenameFiles(fileDir,fileName);
        }
        private void RenameFiles(string filePath, string fileName)
        {
            

            if (Directory.Exists(filePath))
            {  
                //TODO: search through directory find all files.
                DirectoryInfo dir = new DirectoryInfo(filePath);
                FileInfo[] files = dir.GetFiles();
                
                foreach(FileInfo fi in files)
                {
                    //File.Move(fi, fileName);
                    //string EXT = fi.Extension;
                    //string FileName = fi.Name;
                    //string newFileName = FileName;
                    //fi.MoveTo(filePath);
                    fi.Name = 

                    lbViewFiles.Items.Add(fi.Name + " with ext: " + fi.Extension);
                        
                   //lblFilePathPreview.Text = "Change file name";
                }
                

            } 
            
           //TODO: check to make sure the files are not duplicates of that name
           //TODO: change those file names and add the incriment to it.
           //TODO: make an undo button if possable.

        }

        private void File_Name(object sender, EventArgs e)
        {
            fileName = tbFileName.Text;
        }

        private void Min_Incre(object sender, EventArgs e)
        {             
            minIncrement = Convert.ToInt32(dudMin.Text);
        }

        private void Max_Incre(object sender, EventArgs e)
        {
            maxIncrement = Convert.ToInt32(dudMax.Text);
        }
    }
}
