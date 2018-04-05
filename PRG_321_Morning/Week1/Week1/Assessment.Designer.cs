namespace Week1
{
    partial class Assessment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.userEmailInput = new System.Windows.Forms.TextBox();
            this.userPhoneInput = new System.Windows.Forms.TextBox();
            this.displayUserInfo = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayInfoToolStripMenuItem,
            this.clearInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // displayInfoToolStripMenuItem
            // 
            this.displayInfoToolStripMenuItem.Name = "displayInfoToolStripMenuItem";
            this.displayInfoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.displayInfoToolStripMenuItem.Text = "Display Info";
            this.displayInfoToolStripMenuItem.Click += new System.EventHandler(this.displayInfoToolStripMenuItem_Click);
            // 
            // clearInfoToolStripMenuItem
            // 
            this.clearInfoToolStripMenuItem.Name = "clearInfoToolStripMenuItem";
            this.clearInfoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clearInfoToolStripMenuItem.Text = "Clear Info";
            this.clearInfoToolStripMenuItem.Click += new System.EventHandler(this.clearInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInput.Location = new System.Drawing.Point(167, 95);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 26);
            this.userNameInput.TabIndex = 1;
            // 
            // userEmailInput
            // 
            this.userEmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailInput.Location = new System.Drawing.Point(167, 166);
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.Size = new System.Drawing.Size(100, 26);
            this.userEmailInput.TabIndex = 2;
            // 
            // userPhoneInput
            // 
            this.userPhoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneInput.Location = new System.Drawing.Point(167, 245);
            this.userPhoneInput.Name = "userPhoneInput";
            this.userPhoneInput.Size = new System.Drawing.Size(100, 26);
            this.userPhoneInput.TabIndex = 3;
            // 
            // displayUserInfo
            // 
            this.displayUserInfo.AutoSize = true;
            this.displayUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.displayUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUserInfo.Location = new System.Drawing.Point(487, 95);
            this.displayUserInfo.Name = "displayUserInfo";
            this.displayUserInfo.Size = new System.Drawing.Size(0, 20);
            this.displayUserInfo.TabIndex = 4;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(167, 291);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 37);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number:";
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.displayUserInfo);
            this.Controls.Add(this.userPhoneInput);
            this.Controls.Add(this.userEmailInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox userEmailInput;
        private System.Windows.Forms.TextBox userPhoneInput;
        private System.Windows.Forms.Label displayUserInfo;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}