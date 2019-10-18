namespace Class_Test_1_Practice
{
    partial class frmCounting
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
            this.lblLearn = new System.Windows.Forms.Label();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLearn
            // 
            this.lblLearn.AutoSize = true;
            this.lblLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearn.Location = new System.Drawing.Point(12, 23);
            this.lblLearn.Name = "lblLearn";
            this.lblLearn.Size = new System.Drawing.Size(287, 20);
            this.lblLearn.TabIndex = 0;
            this.lblLearn.Text = "Learing to count in Sepedi and Spanish";
            
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(116, 63);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(75, 23);
            this.btnPractice.TabIndex = 1;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(116, 106);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // frmCounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 141);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.lblLearn);
            this.Name = "frmCounting";
            this.Text = "Counting from 1 to 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLearn;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnTest;
    }
}

