namespace MediaProgram
    {
    partial class frmVideo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
			this.label1 = new System.Windows.Forms.Label();
			this.frmMediaProgram = new System.Windows.Forms.Button();
			this.Setting = new System.Windows.Forms.Button();
			this.mediaNav = new System.Windows.Forms.ComboBox();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.videoPlayList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.removebtnVideo = new System.Windows.Forms.Button();
			this.addbtnVideo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(501, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "video form";
			// 
			// frmMediaProgram
			// 
			this.frmMediaProgram.Location = new System.Drawing.Point(12, 205);
			this.frmMediaProgram.Name = "frmMediaProgram";
			this.frmMediaProgram.Size = new System.Drawing.Size(75, 23);
			this.frmMediaProgram.TabIndex = 1;
			this.frmMediaProgram.Text = "Home";
			this.frmMediaProgram.UseVisualStyleBackColor = true;
			this.frmMediaProgram.Click += new System.EventHandler(this.frmMediaProgram_Click);
			// 
			// Setting
			// 
			this.Setting.Location = new System.Drawing.Point(12, 270);
			this.Setting.Name = "Setting";
			this.Setting.Size = new System.Drawing.Size(75, 23);
			this.Setting.TabIndex = 2;
			this.Setting.Text = "Setting";
			this.Setting.UseVisualStyleBackColor = true;
			this.Setting.Click += new System.EventHandler(this.Setting_Click);
			// 
			// mediaNav
			// 
			this.mediaNav.FormattingEnabled = true;
			this.mediaNav.Items.AddRange(new object[] {
            "Music",
            "Photos",
            "Settings"});
			this.mediaNav.Location = new System.Drawing.Point(12, 12);
			this.mediaNav.Name = "mediaNav";
			this.mediaNav.Size = new System.Drawing.Size(121, 21);
			this.mediaNav.TabIndex = 4;
			this.mediaNav.SelectedIndexChanged += new System.EventHandler(this.mediaNav_SelectedIndexChanged);
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(221, 39);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(599, 394);
			this.axWindowsMediaPlayer1.TabIndex = 5;
			// 
			// videoPlayList
			// 
			this.videoPlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.videoPlayList.Location = new System.Drawing.Point(826, 59);
			this.videoPlayList.Name = "videoPlayList";
			this.videoPlayList.Size = new System.Drawing.Size(190, 325);
			this.videoPlayList.TabIndex = 6;
			this.videoPlayList.UseCompatibleStateImageBehavior = false;
			this.videoPlayList.SelectedIndexChanged += new System.EventHandler(this.videoPlayList_SelectedIndexChanged);
			// 
			// removebtnVideo
			// 
			this.removebtnVideo.Location = new System.Drawing.Point(826, 390);
			this.removebtnVideo.Name = "removebtnVideo";
			this.removebtnVideo.Size = new System.Drawing.Size(86, 27);
			this.removebtnVideo.TabIndex = 7;
			this.removebtnVideo.Text = "Remove";
			this.removebtnVideo.UseVisualStyleBackColor = true;
			// 
			// addbtnVideo
			// 
			this.addbtnVideo.Location = new System.Drawing.Point(930, 390);
			this.addbtnVideo.Name = "addbtnVideo";
			this.addbtnVideo.Size = new System.Drawing.Size(86, 27);
			this.addbtnVideo.TabIndex = 8;
			this.addbtnVideo.Text = "Add";
			this.addbtnVideo.UseVisualStyleBackColor = true;
			// 
			// frmVideo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 445);
			this.Controls.Add(this.addbtnVideo);
			this.Controls.Add(this.removebtnVideo);
			this.Controls.Add(this.videoPlayList);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.mediaNav);
			this.Controls.Add(this.Setting);
			this.Controls.Add(this.frmMediaProgram);
			this.Controls.Add(this.label1);
			this.Name = "frmVideo";
			this.Text = "frmVideo";
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button frmMediaProgram;
		private System.Windows.Forms.Button Setting;
		private System.Windows.Forms.ComboBox mediaNav;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.ListView videoPlayList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button removebtnVideo;
		private System.Windows.Forms.Button addbtnVideo;
        }
    }