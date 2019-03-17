namespace KeyMouseCapture
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
			this.lbFrmMain = new System.Windows.Forms.ListBox();
			this.pnlHIDE = new System.Windows.Forms.Panel();
			this.rtDiag = new System.Windows.Forms.RichTextBox();
			this.pnlHIDE.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbFrmMain
			// 
			this.lbFrmMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFrmMain.FormattingEnabled = true;
			this.lbFrmMain.HorizontalScrollbar = true;
			this.lbFrmMain.Location = new System.Drawing.Point(63, 13);
			this.lbFrmMain.Name = "lbFrmMain";
			this.lbFrmMain.Size = new System.Drawing.Size(674, 381);
			this.lbFrmMain.TabIndex = 0;
			// 
			// pnlHIDE
			// 
			this.pnlHIDE.BackColor = System.Drawing.Color.DarkGray;
			this.pnlHIDE.Controls.Add(this.rtDiag);
			this.pnlHIDE.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHIDE.Location = new System.Drawing.Point(0, 0);
			this.pnlHIDE.Name = "pnlHIDE";
			this.pnlHIDE.Size = new System.Drawing.Size(800, 450);
			this.pnlHIDE.TabIndex = 1;
			// 
			// rtDiag
			// 
			this.rtDiag.Location = new System.Drawing.Point(12, 12);
			this.rtDiag.Name = "rtDiag";
			this.rtDiag.Size = new System.Drawing.Size(731, 739);
			this.rtDiag.TabIndex = 0;
			this.rtDiag.Text = "";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlHIDE);
			this.Controls.Add(this.lbFrmMain);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.DarkGray;
			this.pnlHIDE.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbFrmMain;
		private System.Windows.Forms.Panel pnlHIDE;
		private System.Windows.Forms.RichTextBox rtDiag;
	}
}

