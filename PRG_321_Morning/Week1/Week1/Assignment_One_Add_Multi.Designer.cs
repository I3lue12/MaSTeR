namespace Week1
{
    partial class Assignment_One
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
            this.inputOne = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.m_button_multi = new System.Windows.Forms.Button();
            this.feedBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputOne
            // 
            this.inputOne.AutoSize = true;
            this.inputOne.Location = new System.Drawing.Point(31, 30);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(50, 13);
            this.inputOne.TabIndex = 0;
            this.inputOne.Text = "inputOne";
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(164, 30);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 20);
            this.firstInput.TabIndex = 1;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(34, 79);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(66, 13);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "secondInput";
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(164, 79);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 20);
            this.secondInput.TabIndex = 3;
            this.secondInput.TextChanged += new System.EventHandler(this.secondInput_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(37, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // m_button_multi
            // 
            this.m_button_multi.Location = new System.Drawing.Point(164, 130);
            this.m_button_multi.Name = "m_button_multi";
            this.m_button_multi.Size = new System.Drawing.Size(75, 23);
            this.m_button_multi.TabIndex = 5;
            this.m_button_multi.Text = "*";
            this.m_button_multi.UseVisualStyleBackColor = true;
            this.m_button_multi.Click += new System.EventHandler(this.m_button_multi_Click);
            // 
            // feedBack
            // 
            this.feedBack.AutoSize = true;
            this.feedBack.Location = new System.Drawing.Point(37, 240);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(0, 13);
            this.feedBack.TabIndex = 6;
            // 
            // Assignment_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 442);
            this.Controls.Add(this.feedBack);
            this.Controls.Add(this.m_button_multi);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.inputOne);
            this.Name = "Assignment_One";
            this.Text = "Assignment_One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputOne;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button m_button_multi;
        private System.Windows.Forms.Label feedBack;
    }
}