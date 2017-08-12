namespace MediaProgram
{
    partial class MediaProgram
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
            this.dropPlay = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchMedia = new System.Windows.Forms.Button();
            this.DropMediaHere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dropPlay
            // 
            this.dropPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPlay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dropPlay.Location = new System.Drawing.Point(398, 119);
            this.dropPlay.Name = "dropPlay";
            this.dropPlay.Size = new System.Drawing.Size(525, 377);
            this.dropPlay.TabIndex = 0;
            this.dropPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.dropPlay_Paint);
            this.dropPlay.MouseEnter += new System.EventHandler(this.dropPlay_MouseEnter);
            this.dropPlay.MouseLeave += new System.EventHandler(this.dropPlay_MouseLeave);
            this.dropPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dropPlay_MouseMove);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // searchMedia
            // 
            this.searchMedia.Location = new System.Drawing.Point(604, 534);
            this.searchMedia.Name = "searchMedia";
            this.searchMedia.Size = new System.Drawing.Size(100, 25);
            this.searchMedia.TabIndex = 2;
            this.searchMedia.Text = "Search Media";
            this.searchMedia.UseVisualStyleBackColor = true;
            this.searchMedia.Click += new System.EventHandler(this.searchMedia_Click);
            // 
            // DropMediaHere
            // 
            this.DropMediaHere.Location = new System.Drawing.Point(500, 84);
            this.DropMediaHere.Name = "DropMediaHere";
            this.DropMediaHere.Size = new System.Drawing.Size(300, 20);
            this.DropMediaHere.TabIndex = 3;
            this.DropMediaHere.Text = "Drag and drop  your media in the box!\r\n";
            this.DropMediaHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DropMediaHere.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MediaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MediaProgram.Properties.Resources.grungy_blue_texture_by_waitq_d6u7g9q;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DropMediaHere);
            this.Controls.Add(this.searchMedia);
            this.Controls.Add(this.dropPlay);
            this.Name = "MediaProgram";
            this.Text = "MediaProgram";
            this.Load += new System.EventHandler(this.MediaProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dropPlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button searchMedia;
        private System.Windows.Forms.TextBox DropMediaHere;
    }
}

