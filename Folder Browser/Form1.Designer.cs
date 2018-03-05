namespace Folder_Browser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnShowFiles = new System.Windows.Forms.Button();
            this.rtbShowFiles = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.Enabled = false;
            this.btnShowFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnShowFiles.Location = new System.Drawing.Point(13, 73);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(185, 55);
            this.btnShowFiles.TabIndex = 1;
            this.btnShowFiles.Text = "Show Files";
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // rtbShowFiles
            // 
            this.rtbShowFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rtbShowFiles.Location = new System.Drawing.Point(13, 146);
            this.rtbShowFiles.Name = "rtbShowFiles";
            this.rtbShowFiles.Size = new System.Drawing.Size(599, 275);
            this.rtbShowFiles.TabIndex = 2;
            this.rtbShowFiles.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 423);
            this.Controls.Add(this.rtbShowFiles);
            this.Controls.Add(this.btnShowFiles);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnShowFiles;
        private System.Windows.Forms.RichTextBox rtbShowFiles;
    }
}

