namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.firstSemesterBx = new System.Windows.Forms.TextBox();
            this.secondSemesterBx = new System.Windows.Forms.TextBox();
            this.thirdSemesterBx = new System.Windows.Forms.TextBox();
            this.resultBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Semester";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Third Semester";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(365, 214);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 50);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // firstSemesterBx
            // 
            this.firstSemesterBx.Location = new System.Drawing.Point(176, 28);
            this.firstSemesterBx.Name = "firstSemesterBx";
            this.firstSemesterBx.Size = new System.Drawing.Size(126, 20);
            this.firstSemesterBx.TabIndex = 4;
            this.firstSemesterBx.TextChanged += new System.EventHandler(this.firstSemesterBx_TextChanged);
            // 
            // secondSemesterBx
            // 
            this.secondSemesterBx.Location = new System.Drawing.Point(176, 96);
            this.secondSemesterBx.Name = "secondSemesterBx";
            this.secondSemesterBx.Size = new System.Drawing.Size(126, 20);
            this.secondSemesterBx.TabIndex = 5;
            this.secondSemesterBx.TextChanged += new System.EventHandler(this.secondSemesterBx_TextChanged);
            // 
            // thirdSemesterBx
            // 
            this.thirdSemesterBx.Location = new System.Drawing.Point(176, 166);
            this.thirdSemesterBx.Name = "thirdSemesterBx";
            this.thirdSemesterBx.Size = new System.Drawing.Size(126, 20);
            this.thirdSemesterBx.TabIndex = 6;
            this.thirdSemesterBx.TextChanged += new System.EventHandler(this.thirdSemesterBx_TextChanged);
            // 
            // resultBx
            // 
            this.resultBx.Location = new System.Drawing.Point(268, 296);
            this.resultBx.Multiline = true;
            this.resultBx.Name = "resultBx";
            this.resultBx.Size = new System.Drawing.Size(294, 111);
            this.resultBx.TabIndex = 7;
            this.resultBx.TextChanged += new System.EventHandler(this.resultBx_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBx);
            this.Controls.Add(this.thirdSemesterBx);
            this.Controls.Add(this.secondSemesterBx);
            this.Controls.Add(this.firstSemesterBx);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox firstSemesterBx;
        private System.Windows.Forms.TextBox secondSemesterBx;
        private System.Windows.Forms.TextBox thirdSemesterBx;
        private System.Windows.Forms.TextBox resultBx;
    }
}

