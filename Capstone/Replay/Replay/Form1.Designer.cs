namespace Replay
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
			this.lbViewFiles = new System.Windows.Forms.ListBox();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbViewFiles
			// 
			this.lbViewFiles.FormattingEnabled = true;
			this.lbViewFiles.Location = new System.Drawing.Point(309, 75);
			this.lbViewFiles.Name = "lbViewFiles";
			this.lbViewFiles.ScrollAlwaysVisible = true;
			this.lbViewFiles.Size = new System.Drawing.Size(333, 277);
			this.lbViewFiles.TabIndex = 0;
			this.lbViewFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbViewFiles_DrawItem);
			this.lbViewFiles.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbViewFiles_MeasureItem);
			this.lbViewFiles.SelectedIndexChanged += new System.EventHandler(this.lbViewFiles_SelectedIndexChanged);
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(309, 40);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(309, 359);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 2;
			this.btnPlay.Text = "PLAY";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.lbViewFiles);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbViewFiles;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.Button btnPlay;
	}
}

