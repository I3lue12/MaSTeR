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
            this.button1 = new System.Windows.Forms.Button();
            this.DragAndDropPlay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dropPlay
            // 
            this.dropPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPlay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dropPlay.Location = new System.Drawing.Point(392, 130);
            this.dropPlay.Name = "dropPlay";
            this.dropPlay.Size = new System.Drawing.Size(525, 377);
            this.dropPlay.TabIndex = 0;
            this.dropPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.dropPlay_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search Media";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DragAndDropPlay
            // 
            this.DragAndDropPlay.Location = new System.Drawing.Point(503, 87);
            this.DragAndDropPlay.Name = "DragAndDropPlay";
            this.DragAndDropPlay.Size = new System.Drawing.Size(300, 20);
            this.DragAndDropPlay.TabIndex = 3;
            this.DragAndDropPlay.Text = "Drag and drop a movie, music, or photo here.\r\n";
            this.DragAndDropPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DragAndDropPlay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MediaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MediaProgram.Properties.Resources.grungy_blue_texture_by_waitq_d6u7g9q;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DragAndDropPlay);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DragAndDropPlay;
    }
}

