namespace WindowsFormsApp2_filemanager
{
    partial class CRecursiveBrowseDlg
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
            this.lblStartDir = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.richTextBox_lbOutput = new System.Windows.Forms.RichTextBox();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStartDir
            // 
            this.lblStartDir.AutoSize = true;
            this.lblStartDir.Location = new System.Drawing.Point(20, 42);
            this.lblStartDir.Name = "lblStartDir";
            this.lblStartDir.Size = new System.Drawing.Size(35, 13);
            this.lblStartDir.TabIndex = 0;
            this.lblStartDir.Text = "label1";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(327, 40);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(35, 13);
            this.lblPattern.TabIndex = 1;
            this.lblPattern.Text = "label2";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(257, 92);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(53, 49);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.BackColorChanged += new System.EventHandler(this.btnBrowse_BackColorChanged);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(553, 92);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 49);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(37, 175);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label3";
            // 
            // richTextBox_lbOutput
            // 
            this.richTextBox_lbOutput.Location = new System.Drawing.Point(30, 271);
            this.richTextBox_lbOutput.Name = "richTextBox_lbOutput";
            this.richTextBox_lbOutput.Size = new System.Drawing.Size(552, 252);
            this.richTextBox_lbOutput.TabIndex = 5;
            this.richTextBox_lbOutput.Text = "lbOutput.\nChú ý các subfolder phải được OS cho phép truy cập.";
            this.richTextBox_lbOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtStartDir
            // 
            this.txtStartDir.Location = new System.Drawing.Point(30, 95);
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(221, 20);
            this.txtStartDir.TabIndex = 6;
            this.txtStartDir.Text = "D:\\Temporary";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(316, 107);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(222, 20);
            this.txtPattern.TabIndex = 7;
            this.txtPattern.Text = "*.exe";
            // 
            // CRecursiveBrowseDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 570);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtStartDir);
            this.Controls.Add(this.richTextBox_lbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblStartDir);
            this.Name = "CRecursiveBrowseDlg";
            this.Text = "CRecursiveBrowseDlg";
            this.Load += new System.EventHandler(this.CRecursiveBrowseDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPattern;
        protected System.Windows.Forms.Label lblStartDir;
        protected System.Windows.Forms.Button btnBrowse;
        protected System.Windows.Forms.TextBox txtStartDir;
        protected System.Windows.Forms.Label lblPattern;
        protected System.Windows.Forms.Button btnStart;
        protected System.Windows.Forms.Label lblOutput;
        protected System.Windows.Forms.RichTextBox richTextBox_lbOutput;
    }
}