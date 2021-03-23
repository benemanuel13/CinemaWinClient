
namespace CinemaWinClient.Forms
{
    partial class UploadFilmForm
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
            this.FileName = new System.Windows.Forms.TextBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.UploadProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadFile = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film File Location";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(22, 41);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(550, 23);
            this.FileName.TabIndex = 1;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(460, 70);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(112, 23);
            this.selectFile.TabIndex = 2;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // UploadProgress
            // 
            this.UploadProgress.Location = new System.Drawing.Point(22, 119);
            this.UploadProgress.Name = "UploadProgress";
            this.UploadProgress.Size = new System.Drawing.Size(419, 23);
            this.UploadProgress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upload Progress";
            // 
            // uploadFile
            // 
            this.uploadFile.Enabled = false;
            this.uploadFile.Location = new System.Drawing.Point(460, 119);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(112, 23);
            this.uploadFile.TabIndex = 5;
            this.uploadFile.Text = "Upload File";
            this.uploadFile.UseVisualStyleBackColor = true;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(460, 186);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(112, 23);
            this.closeForm.TabIndex = 6;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // UploadFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 227);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.uploadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UploadProgress);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.ProgressBar UploadProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}