namespace GUIDatabase
{
    partial class frmMain
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
            this.row = new System.Windows.Forms.DataGridView();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTest = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.row.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Name,
            this.Last_Name,
            this.Student_ID});
            this.row.Location = new System.Drawing.Point(12, 7);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(525, 374);
            this.row.TabIndex = 0;
            // 
            // Student_Name
            // 
            this.Student_Name.HeaderText = "First_Name";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.ReadOnly = true;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last_Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Location = new System.Drawing.Point(543, 62);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(245, 95);
            this.lbTest.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.row);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.ListBox lbTest;
    }
}

