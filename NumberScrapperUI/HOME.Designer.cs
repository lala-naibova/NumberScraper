namespace NumberScrapperUI
{
    partial class HOME
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBroseFolder = new System.Windows.Forms.Button();
            this.btnBroseFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectedFilesCount = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(158, 255);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 49);
            this.progressBar1.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 49);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select files to parse...";
            // 
            // btnBroseFolder
            // 
            this.btnBroseFolder.Location = new System.Drawing.Point(15, 166);
            this.btnBroseFolder.Name = "btnBroseFolder";
            this.btnBroseFolder.Size = new System.Drawing.Size(112, 38);
            this.btnBroseFolder.TabIndex = 8;
            this.btnBroseFolder.Text = "Brose folder";
            this.btnBroseFolder.UseVisualStyleBackColor = true;
            this.btnBroseFolder.Click += new System.EventHandler(this.btnBroseFolder_Click);
            // 
            // btnBroseFiles
            // 
            this.btnBroseFiles.Location = new System.Drawing.Point(12, 42);
            this.btnBroseFiles.Name = "btnBroseFiles";
            this.btnBroseFiles.Size = new System.Drawing.Size(112, 36);
            this.btnBroseFiles.TabIndex = 7;
            this.btnBroseFiles.Text = "Browse files";
            this.btnBroseFiles.UseVisualStyleBackColor = true;
            this.btnBroseFiles.Click += new System.EventHandler(this.btnBroseFiles_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // lblSelectedFilesCount
            // 
            this.lblSelectedFilesCount.AutoSize = true;
            this.lblSelectedFilesCount.Location = new System.Drawing.Point(175, 65);
            this.lblSelectedFilesCount.Name = "lblSelectedFilesCount";
            this.lblSelectedFilesCount.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedFilesCount.TabIndex = 14;
            this.lblSelectedFilesCount.Text = "No files selected.";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(175, 191);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(106, 13);
            this.lblFolderPath.TabIndex = 15;
            this.lblFolderPath.Text = "Selected Folder Path";
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 462);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.lblSelectedFilesCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBroseFolder);
            this.Controls.Add(this.btnBroseFiles);
            this.Name = "HOME";
            this.Text = "Number Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBroseFolder;
        private System.Windows.Forms.Button btnBroseFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblSelectedFilesCount;
        private System.Windows.Forms.Label lblFolderPath;
    }
}

