namespace Week1
{
    partial class Notes
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
            this.m_button_multi = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.inputOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_button_multi
            // 
            this.m_button_multi.Location = new System.Drawing.Point(179, 127);
            this.m_button_multi.Name = "m_button_multi";
            this.m_button_multi.Size = new System.Drawing.Size(75, 23);
            this.m_button_multi.TabIndex = 11;
            this.m_button_multi.Text = "*";
            this.m_button_multi.UseVisualStyleBackColor = true;
            this.m_button_multi.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(52, 127);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(179, 76);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 20);
            this.secondInput.TabIndex = 9;
            this.secondInput.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(49, 76);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(66, 13);
            this.lable2.TabIndex = 8;
            this.lable2.Text = "secondInput";
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(179, 27);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 20);
            this.firstInput.TabIndex = 7;
            this.firstInput.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // inputOne
            // 
            this.inputOne.AutoSize = true;
            this.inputOne.Location = new System.Drawing.Point(46, 27);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(50, 13);
            this.inputOne.TabIndex = 6;
            this.inputOne.Text = "inputOne";
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 413);
            this.Controls.Add(this.m_button_multi);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.inputOne);
            this.Name = "Notes";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_button_multi;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.Label inputOne;
    }
}