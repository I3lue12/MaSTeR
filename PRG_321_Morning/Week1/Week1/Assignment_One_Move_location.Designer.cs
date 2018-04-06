namespace Week1
{
    partial class Assignment_One_Move_location
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
            this.xCordInput = new System.Windows.Forms.TextBox();
            this.yCordInput = new System.Windows.Forms.TextBox();
            this.newPos = new System.Windows.Forms.Button();
            this.m_label_first_name = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xCordInput
            // 
            this.xCordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCordInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.xCordInput.HideSelection = false;
            this.xCordInput.Location = new System.Drawing.Point(318, 22);
            this.xCordInput.Name = "xCordInput";
            this.xCordInput.Size = new System.Drawing.Size(100, 24);
            this.xCordInput.TabIndex = 0;
            this.xCordInput.WordWrap = false;
            // 
            // yCordInput
            // 
            this.yCordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCordInput.Location = new System.Drawing.Point(318, 82);
            this.yCordInput.Name = "yCordInput";
            this.yCordInput.Size = new System.Drawing.Size(100, 24);
            this.yCordInput.TabIndex = 1;
            // 
            // newPos
            // 
            this.newPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPos.Location = new System.Drawing.Point(38, 172);
            this.newPos.Name = "newPos";
            this.newPos.Size = new System.Drawing.Size(380, 35);
            this.newPos.TabIndex = 2;
            this.newPos.Text = "Click For New Position";
            this.newPos.UseVisualStyleBackColor = true;
            this.newPos.Click += new System.EventHandler(this.newPos_Click);
            // 
            // m_label_first_name
            // 
            this.m_label_first_name.AutoSize = true;
            this.m_label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_first_name.Location = new System.Drawing.Point(34, 26);
            this.m_label_first_name.Name = "m_label_first_name";
            this.m_label_first_name.Size = new System.Drawing.Size(173, 20);
            this.m_label_first_name.TabIndex = 3;
            this.m_label_first_name.Text = "Enter In coordinates";
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback.Location = new System.Drawing.Point(38, 334);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(0, 20);
            this.feedback.TabIndex = 4;
            // 
            // Assignment_One_Move_location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.m_label_first_name);
            this.Controls.Add(this.newPos);
            this.Controls.Add(this.yCordInput);
            this.Controls.Add(this.xCordInput);
            this.Name = "Assignment_One_Move_location";
            this.Text = "Week_One_PRG_321";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xCordInput;
        private System.Windows.Forms.TextBox yCordInput;
        private System.Windows.Forms.Button newPos;
        private System.Windows.Forms.Label m_label_first_name;
        private System.Windows.Forms.Label feedback;
    }
}

