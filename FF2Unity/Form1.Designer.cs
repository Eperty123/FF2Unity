namespace FF2Unity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cacheBrowseBtn = new System.Windows.Forms.Button();
            this.cacheTxtBox = new System.Windows.Forms.TextBox();
            this.cacheLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.creditsLinkLbl = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cacheBrowseBtn);
            this.groupBox1.Controls.Add(this.cacheTxtBox);
            this.groupBox1.Controls.Add(this.cacheLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FusionFall Caches";
            // 
            // cacheBrowseBtn
            // 
            this.cacheBrowseBtn.Location = new System.Drawing.Point(6, 69);
            this.cacheBrowseBtn.Name = "cacheBrowseBtn";
            this.cacheBrowseBtn.Size = new System.Drawing.Size(188, 23);
            this.cacheBrowseBtn.TabIndex = 2;
            this.cacheBrowseBtn.Text = "Browse";
            this.cacheBrowseBtn.UseVisualStyleBackColor = true;
            this.cacheBrowseBtn.Click += new System.EventHandler(this.cacheBrowseBtn_Click);
            // 
            // cacheTxtBox
            // 
            this.cacheTxtBox.Location = new System.Drawing.Point(6, 43);
            this.cacheTxtBox.Name = "cacheTxtBox";
            this.cacheTxtBox.Size = new System.Drawing.Size(188, 20);
            this.cacheTxtBox.TabIndex = 1;
            // 
            // cacheLbl
            // 
            this.cacheLbl.AutoSize = true;
            this.cacheLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheLbl.Location = new System.Drawing.Point(6, 27);
            this.cacheLbl.Name = "cacheLbl";
            this.cacheLbl.Size = new System.Drawing.Size(82, 13);
            this.cacheLbl.TabIndex = 0;
            this.cacheLbl.Text = "Cache Folder";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(218, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 164);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // creditsLinkLbl
            // 
            this.creditsLinkLbl.AutoSize = true;
            this.creditsLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLinkLbl.Location = new System.Drawing.Point(9, 163);
            this.creditsLinkLbl.Name = "creditsLinkLbl";
            this.creditsLinkLbl.Size = new System.Drawing.Size(86, 13);
            this.creditsLinkLbl.TabIndex = 2;
            this.creditsLinkLbl.TabStop = true;
            this.creditsLinkLbl.Text = "By: Eperty123";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 188);
            this.Controls.Add(this.creditsLinkLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FF2Unity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cacheBrowseBtn;
        private System.Windows.Forms.TextBox cacheTxtBox;
        private System.Windows.Forms.Label cacheLbl;
        private System.Windows.Forms.LinkLabel creditsLinkLbl;
    }
}

