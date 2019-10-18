namespace Class_Test_1_Practice
{
    partial class frmPractice
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
            this.mnsInfo = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLanguage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsInfo
            // 
            this.mnsInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.mnsInfo.Location = new System.Drawing.Point(0, 0);
            this.mnsInfo.Name = "mnsInfo";
            this.mnsInfo.Size = new System.Drawing.Size(429, 29);
            this.mnsInfo.TabIndex = 0;
            this.mnsInfo.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // dgvLanguage
            // 
            this.dgvLanguage.AllowUserToAddRows = false;
            this.dgvLanguage.AllowUserToDeleteRows = false;
            this.dgvLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLanguage.Location = new System.Drawing.Point(12, 54);
            this.dgvLanguage.Name = "dgvLanguage";
            this.dgvLanguage.ReadOnly = true;
            this.dgvLanguage.Size = new System.Drawing.Size(348, 259);
            this.dgvLanguage.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "English";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Spanish";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sepedi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.dgvLanguage);
            this.Controls.Add(this.mnsInfo);
            this.MainMenuStrip = this.mnsInfo;
            this.Name = "frmPractice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.frmPractice_Load);
            this.mnsInfo.ResumeLayout(false);
            this.mnsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsInfo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}