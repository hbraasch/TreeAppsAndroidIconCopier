namespace AndroidIconCopier
{
    partial class frmStartup
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
            this.btnCopyImages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseSourceFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.boxSourceFiles = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxDestinationFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseDestFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopyImages
            // 
            this.btnCopyImages.Location = new System.Drawing.Point(411, 301);
            this.btnCopyImages.Name = "btnCopyImages";
            this.btnCopyImages.Size = new System.Drawing.Size(145, 29);
            this.btnCopyImages.TabIndex = 0;
            this.btnCopyImages.Text = "Copy";
            this.btnCopyImages.UseVisualStyleBackColor = true;
            this.btnCopyImages.Click += new System.EventHandler(this.btnCopyImages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxSourceFiles);
            this.groupBox1.Controls.Add(this.btnBrowseSourceFiles);
            this.groupBox1.Location = new System.Drawing.Point(90, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source file (Zip file with Android \'res\' files, generated using Android Asset Stu" +
    "dio)";
            // 
            // btnBrowseSourceFiles
            // 
            this.btnBrowseSourceFiles.Location = new System.Drawing.Point(803, 16);
            this.btnBrowseSourceFiles.Name = "btnBrowseSourceFiles";
            this.btnBrowseSourceFiles.Size = new System.Drawing.Size(65, 28);
            this.btnBrowseSourceFiles.TabIndex = 0;
            this.btnBrowseSourceFiles.Text = "Browse";
            this.btnBrowseSourceFiles.UseVisualStyleBackColor = true;
            this.btnBrowseSourceFiles.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // boxSourceFiles
            // 
            this.boxSourceFiles.AcceptsReturn = true;
            this.boxSourceFiles.Location = new System.Drawing.Point(27, 21);
            this.boxSourceFiles.Multiline = true;
            this.boxSourceFiles.Name = "boxSourceFiles";
            this.boxSourceFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxSourceFiles.Size = new System.Drawing.Size(749, 110);
            this.boxSourceFiles.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxDestinationFolder);
            this.groupBox2.Controls.Add(this.btnBrowseDestFolder);
            this.groupBox2.Location = new System.Drawing.Point(89, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination folder (\'res\' folder in Android IDE)";
            // 
            // boxDestinationFolder
            // 
            this.boxDestinationFolder.Location = new System.Drawing.Point(27, 21);
            this.boxDestinationFolder.Name = "boxDestinationFolder";
            this.boxDestinationFolder.Size = new System.Drawing.Size(750, 20);
            this.boxDestinationFolder.TabIndex = 1;
            // 
            // btnBrowseDestFolder
            // 
            this.btnBrowseDestFolder.Location = new System.Drawing.Point(804, 13);
            this.btnBrowseDestFolder.Name = "btnBrowseDestFolder";
            this.btnBrowseDestFolder.Size = new System.Drawing.Size(65, 28);
            this.btnBrowseDestFolder.TabIndex = 0;
            this.btnBrowseDestFolder.Text = "Browse";
            this.btnBrowseDestFolder.UseVisualStyleBackColor = true;
            this.btnBrowseDestFolder.Click += new System.EventHandler(this.btnBrowseDestFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zip files must have the same name as the resource (just differnt file extensions)" +
    "";
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyImages);
            this.Name = "frmStartup";
            this.Text = "Fasr copy Android Images to Android IDE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseSourceFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox boxSourceFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox boxDestinationFolder;
        private System.Windows.Forms.Button btnBrowseDestFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
    }
}

