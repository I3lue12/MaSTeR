namespace FileCreationNManagment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateNewFile = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.cbIncrement = new System.Windows.Forms.CheckBox();
            this.lblFilePathPreview = new System.Windows.Forms.Label();
            this.lbViewFiles = new System.Windows.Forms.ListBox();
            this.dudMin = new System.Windows.Forms.DomainUpDown();
            this.dudMax = new System.Windows.Forms.DomainUpDown();
            this.lblFileNamePre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNameOrgin = new System.Windows.Forms.Button();
            this.btnDateOrgin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.Location = new System.Drawing.Point(12, 388);
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(144, 23);
            this.btnCreateNewFile.TabIndex = 0;
            this.btnCreateNewFile.Text = "File Name Change";
            this.btnCreateNewFile.UseVisualStyleBackColor = true;
            this.btnCreateNewFile.Click += new System.EventHandler(this.btn_createNewFile);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(12, 12);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(198, 20);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Text = "File Path";
            this.tbFilePath.Click += new System.EventHandler(this.Clear_File_path);
            this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(12, 52);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(198, 20);
            this.tbFileName.TabIndex = 2;
            this.tbFileName.Text = "File Name";
            this.tbFileName.Click += new System.EventHandler(this.Clear_File_Name);
            this.tbFileName.TextChanged += new System.EventHandler(this.File_Name);
            // 
            // cbIncrement
            // 
            this.cbIncrement.AutoSize = true;
            this.cbIncrement.Location = new System.Drawing.Point(68, 92);
            this.cbIncrement.Name = "cbIncrement";
            this.cbIncrement.Size = new System.Drawing.Size(73, 17);
            this.cbIncrement.TabIndex = 3;
            this.cbIncrement.Text = "Increment";
            this.cbIncrement.UseVisualStyleBackColor = true;
            // 
            // lblFilePathPreview
            // 
            this.lblFilePathPreview.AutoSize = true;
            this.lblFilePathPreview.Location = new System.Drawing.Point(240, 398);
            this.lblFilePathPreview.Name = "lblFilePathPreview";
            this.lblFilePathPreview.Size = new System.Drawing.Size(89, 13);
            this.lblFilePathPreview.TabIndex = 4;
            this.lblFilePathPreview.Text = "File Path Preview";
            // 
            // lbViewFiles
            // 
            this.lbViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbViewFiles.FormattingEnabled = true;
            this.lbViewFiles.Location = new System.Drawing.Point(243, 52);
            this.lbViewFiles.Name = "lbViewFiles";
            this.lbViewFiles.Size = new System.Drawing.Size(545, 329);
            this.lbViewFiles.TabIndex = 6;
            this.lbViewFiles.Click += new System.EventHandler(this.SelectedToGoToClip);
            // 
            // dudMin
            // 
            this.dudMin.Location = new System.Drawing.Point(12, 126);
            this.dudMin.Name = "dudMin";
            this.dudMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dudMin.Size = new System.Drawing.Size(79, 20);
            this.dudMin.TabIndex = 7;
            this.dudMin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dudMin.SelectedItemChanged += new System.EventHandler(this.Min_Incre);
            // 
            // dudMax
            // 
            this.dudMax.Location = new System.Drawing.Point(130, 126);
            this.dudMax.Name = "dudMax";
            this.dudMax.Size = new System.Drawing.Size(80, 20);
            this.dudMax.TabIndex = 8;
            this.dudMax.SelectedItemChanged += new System.EventHandler(this.Max_Incre);
            // 
            // lblFileNamePre
            // 
            this.lblFileNamePre.AutoSize = true;
            this.lblFileNamePre.Location = new System.Drawing.Point(13, 174);
            this.lblFileNamePre.Name = "lblFileNamePre";
            this.lblFileNamePre.Size = new System.Drawing.Size(95, 13);
            this.lblFileNamePre.TabIndex = 9;
            this.lblFileNamePre.Text = "File Name Preview";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(705, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear);
            // 
            // btnNameOrgin
            // 
            this.btnNameOrgin.Location = new System.Drawing.Point(341, 23);
            this.btnNameOrgin.Name = "btnNameOrgin";
            this.btnNameOrgin.Size = new System.Drawing.Size(75, 23);
            this.btnNameOrgin.TabIndex = 11;
            this.btnNameOrgin.Text = "By Name";
            this.btnNameOrgin.UseVisualStyleBackColor = true;
            this.btnNameOrgin.Click += new System.EventHandler(this.btnNameOrgin_Click);
            // 
            // btnDateOrgin
            // 
            this.btnDateOrgin.Location = new System.Drawing.Point(658, 23);
            this.btnDateOrgin.Name = "btnDateOrgin";
            this.btnDateOrgin.Size = new System.Drawing.Size(75, 23);
            this.btnDateOrgin.TabIndex = 12;
            this.btnDateOrgin.Text = "By Date";
            this.btnDateOrgin.UseVisualStyleBackColor = true;
            this.btnDateOrgin.Click += new System.EventHandler(this.btnDateOrgin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDateOrgin);
            this.Controls.Add(this.btnNameOrgin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblFileNamePre);
            this.Controls.Add(this.dudMax);
            this.Controls.Add(this.dudMin);
            this.Controls.Add(this.lbViewFiles);
            this.Controls.Add(this.lblFilePathPreview);
            this.Controls.Add(this.cbIncrement);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnCreateNewFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewFile;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.CheckBox cbIncrement;
        private System.Windows.Forms.Label lblFilePathPreview;
        private System.Windows.Forms.ListBox lbViewFiles;
        private System.Windows.Forms.DomainUpDown dudMin;
        private System.Windows.Forms.DomainUpDown dudMax;
        private System.Windows.Forms.Label lblFileNamePre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNameOrgin;
        private System.Windows.Forms.Button btnDateOrgin;
    }
}

