namespace CinemaWinClient.Forms
{
    partial class FilmDetails
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
            this.Screens = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstFilm = new System.Windows.Forms.CheckBox();
            this.saveFilmDetailsButton = new System.Windows.Forms.Button();
            this.Synopsis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FilmLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FilmTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uploadTrailerButton = new System.Windows.Forms.Button();
            this.selectTrailerButton = new System.Windows.Forms.Button();
            this.TrailerUploaded = new System.Windows.Forms.Label();
            this.still3SelectButton = new System.Windows.Forms.Button();
            this.still2UploadtButton = new System.Windows.Forms.Button();
            this.still2SelectButton = new System.Windows.Forms.Button();
            this.still3UploadtButton = new System.Windows.Forms.Button();
            this.still1UploadtButton = new System.Windows.Forms.Button();
            this.still1SelectButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.still3 = new System.Windows.Forms.PictureBox();
            this.still2 = new System.Windows.Forms.PictureBox();
            this.still1 = new System.Windows.Forms.PictureBox();
            this.uploadDirectorButton = new System.Windows.Forms.Button();
            this.selectDirectorFileButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.PictureBox();
            this.uploadPosterButton = new System.Windows.Forms.Button();
            this.selectPosterFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveDirectorButton = new System.Windows.Forms.Button();
            this.Bio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.still3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.still2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.still1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.director)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Screens);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FirstFilm);
            this.groupBox1.Controls.Add(this.saveFilmDetailsButton);
            this.groupBox1.Controls.Add(this.Synopsis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.FilmLength);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FilmTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(713, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Details";
            // 
            // Screens
            // 
            this.Screens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Screens.FormattingEnabled = true;
            this.Screens.Location = new System.Drawing.Point(175, 290);
            this.Screens.Name = "Screens";
            this.Screens.Size = new System.Drawing.Size(132, 23);
            this.Screens.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Screen";
            // 
            // FirstFilm
            // 
            this.FirstFilm.AutoSize = true;
            this.FirstFilm.Location = new System.Drawing.Point(22, 289);
            this.FirstFilm.Name = "FirstFilm";
            this.FirstFilm.Size = new System.Drawing.Size(76, 19);
            this.FirstFilm.TabIndex = 4;
            this.FirstFilm.Text = "First Film";
            this.FirstFilm.UseVisualStyleBackColor = true;
            // 
            // saveFilmDetailsButton
            // 
            this.saveFilmDetailsButton.Location = new System.Drawing.Point(350, 285);
            this.saveFilmDetailsButton.Name = "saveFilmDetailsButton";
            this.saveFilmDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.saveFilmDetailsButton.TabIndex = 6;
            this.saveFilmDetailsButton.Text = "Save";
            this.saveFilmDetailsButton.UseVisualStyleBackColor = true;
            this.saveFilmDetailsButton.Click += new System.EventHandler(this.saveFilmDetailsButton_Click);
            // 
            // Synopsis
            // 
            this.Synopsis.Location = new System.Drawing.Point(19, 110);
            this.Synopsis.Multiline = true;
            this.Synopsis.Name = "Synopsis";
            this.Synopsis.Size = new System.Drawing.Size(406, 165);
            this.Synopsis.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Synopsis";
            // 
            // FilmLength
            // 
            this.FilmLength.Location = new System.Drawing.Point(296, 47);
            this.FilmLength.Name = "FilmLength";
            this.FilmLength.Size = new System.Drawing.Size(121, 23);
            this.FilmLength.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Film Length (mins)";
            // 
            // FilmTitle
            // 
            this.FilmTitle.Enabled = false;
            this.FilmTitle.Location = new System.Drawing.Point(19, 47);
            this.FilmTitle.Name = "FilmTitle";
            this.FilmTitle.Size = new System.Drawing.Size(255, 23);
            this.FilmTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uploadTrailerButton);
            this.groupBox2.Controls.Add(this.selectTrailerButton);
            this.groupBox2.Controls.Add(this.TrailerUploaded);
            this.groupBox2.Controls.Add(this.still3SelectButton);
            this.groupBox2.Controls.Add(this.still2UploadtButton);
            this.groupBox2.Controls.Add(this.still2SelectButton);
            this.groupBox2.Controls.Add(this.still3UploadtButton);
            this.groupBox2.Controls.Add(this.still1UploadtButton);
            this.groupBox2.Controls.Add(this.still1SelectButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.still3);
            this.groupBox2.Controls.Add(this.still2);
            this.groupBox2.Controls.Add(this.still1);
            this.groupBox2.Controls.Add(this.uploadDirectorButton);
            this.groupBox2.Controls.Add(this.selectDirectorFileButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.director);
            this.groupBox2.Controls.Add(this.uploadPosterButton);
            this.groupBox2.Controls.Add(this.selectPosterFileButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.poster);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 654);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // uploadTrailerButton
            // 
            this.uploadTrailerButton.Enabled = false;
            this.uploadTrailerButton.Location = new System.Drawing.Point(100, 486);
            this.uploadTrailerButton.Name = "uploadTrailerButton";
            this.uploadTrailerButton.Size = new System.Drawing.Size(75, 23);
            this.uploadTrailerButton.TabIndex = 20;
            this.uploadTrailerButton.Text = "Upload";
            this.uploadTrailerButton.UseVisualStyleBackColor = true;
            this.uploadTrailerButton.Click += new System.EventHandler(this.uploadTrailerButton_Click);
            // 
            // selectTrailerButton
            // 
            this.selectTrailerButton.Location = new System.Drawing.Point(19, 486);
            this.selectTrailerButton.Name = "selectTrailerButton";
            this.selectTrailerButton.Size = new System.Drawing.Size(75, 23);
            this.selectTrailerButton.TabIndex = 19;
            this.selectTrailerButton.Text = "Select File";
            this.selectTrailerButton.UseVisualStyleBackColor = true;
            this.selectTrailerButton.Click += new System.EventHandler(this.selectTrailerButton_Click);
            // 
            // TrailerUploaded
            // 
            this.TrailerUploaded.AutoSize = true;
            this.TrailerUploaded.Location = new System.Drawing.Point(135, 459);
            this.TrailerUploaded.Name = "TrailerUploaded";
            this.TrailerUploaded.Size = new System.Drawing.Size(23, 15);
            this.TrailerUploaded.TabIndex = 5;
            this.TrailerUploaded.Text = "No";
            // 
            // still3SelectButton
            // 
            this.still3SelectButton.Enabled = false;
            this.still3SelectButton.Location = new System.Drawing.Point(408, 515);
            this.still3SelectButton.Name = "still3SelectButton";
            this.still3SelectButton.Size = new System.Drawing.Size(75, 23);
            this.still3SelectButton.TabIndex = 15;
            this.still3SelectButton.Text = "Select File";
            this.still3SelectButton.UseVisualStyleBackColor = true;
            this.still3SelectButton.Click += new System.EventHandler(this.still3SelectButton_Click);
            // 
            // still2UploadtButton
            // 
            this.still2UploadtButton.Enabled = false;
            this.still2UploadtButton.Location = new System.Drawing.Point(489, 345);
            this.still2UploadtButton.Name = "still2UploadtButton";
            this.still2UploadtButton.Size = new System.Drawing.Size(75, 23);
            this.still2UploadtButton.TabIndex = 18;
            this.still2UploadtButton.Text = "Upload";
            this.still2UploadtButton.UseVisualStyleBackColor = true;
            this.still2UploadtButton.Click += new System.EventHandler(this.still2UploadtButton_Click);
            // 
            // still2SelectButton
            // 
            this.still2SelectButton.Enabled = false;
            this.still2SelectButton.Location = new System.Drawing.Point(408, 345);
            this.still2SelectButton.Name = "still2SelectButton";
            this.still2SelectButton.Size = new System.Drawing.Size(75, 23);
            this.still2SelectButton.TabIndex = 17;
            this.still2SelectButton.Text = "Select File";
            this.still2SelectButton.UseVisualStyleBackColor = true;
            this.still2SelectButton.Click += new System.EventHandler(this.still2SelectButton_Click);
            // 
            // still3UploadtButton
            // 
            this.still3UploadtButton.Enabled = false;
            this.still3UploadtButton.Location = new System.Drawing.Point(489, 515);
            this.still3UploadtButton.Name = "still3UploadtButton";
            this.still3UploadtButton.Size = new System.Drawing.Size(75, 23);
            this.still3UploadtButton.TabIndex = 16;
            this.still3UploadtButton.Text = "Upload";
            this.still3UploadtButton.UseVisualStyleBackColor = true;
            this.still3UploadtButton.Click += new System.EventHandler(this.still3UploadtButton_Click);
            // 
            // still1UploadtButton
            // 
            this.still1UploadtButton.Location = new System.Drawing.Point(489, 170);
            this.still1UploadtButton.Name = "still1UploadtButton";
            this.still1UploadtButton.Size = new System.Drawing.Size(75, 23);
            this.still1UploadtButton.TabIndex = 14;
            this.still1UploadtButton.Text = "Upload";
            this.still1UploadtButton.UseVisualStyleBackColor = true;
            this.still1UploadtButton.Click += new System.EventHandler(this.still1UploadtButton_Click);
            // 
            // still1SelectButton
            // 
            this.still1SelectButton.Location = new System.Drawing.Point(408, 170);
            this.still1SelectButton.Name = "still1SelectButton";
            this.still1SelectButton.Size = new System.Drawing.Size(75, 23);
            this.still1SelectButton.TabIndex = 13;
            this.still1SelectButton.Text = "Select File";
            this.still1SelectButton.UseVisualStyleBackColor = true;
            this.still1SelectButton.Click += new System.EventHandler(this.still1SelectButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(377, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Stills";
            // 
            // still3
            // 
            this.still3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.still3.Location = new System.Drawing.Point(377, 391);
            this.still3.Name = "still3";
            this.still3.Size = new System.Drawing.Size(187, 118);
            this.still3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.still3.TabIndex = 11;
            this.still3.TabStop = false;
            // 
            // still2
            // 
            this.still2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.still2.Location = new System.Drawing.Point(377, 221);
            this.still2.Name = "still2";
            this.still2.Size = new System.Drawing.Size(187, 118);
            this.still2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.still2.TabIndex = 10;
            this.still2.TabStop = false;
            // 
            // still1
            // 
            this.still1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.still1.Location = new System.Drawing.Point(377, 46);
            this.still1.Name = "still1";
            this.still1.Size = new System.Drawing.Size(187, 118);
            this.still1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.still1.TabIndex = 9;
            this.still1.TabStop = false;
            // 
            // uploadDirectorButton
            // 
            this.uploadDirectorButton.Location = new System.Drawing.Point(221, 405);
            this.uploadDirectorButton.Name = "uploadDirectorButton";
            this.uploadDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.uploadDirectorButton.TabIndex = 8;
            this.uploadDirectorButton.Text = "Upload";
            this.uploadDirectorButton.UseVisualStyleBackColor = true;
            this.uploadDirectorButton.Click += new System.EventHandler(this.uploadDirectorButton_Click);
            // 
            // selectDirectorFileButton
            // 
            this.selectDirectorFileButton.Location = new System.Drawing.Point(221, 375);
            this.selectDirectorFileButton.Name = "selectDirectorFileButton";
            this.selectDirectorFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectDirectorFileButton.TabIndex = 7;
            this.selectDirectorFileButton.Text = "Select File";
            this.selectDirectorFileButton.UseVisualStyleBackColor = true;
            this.selectDirectorFileButton.Click += new System.EventHandler(this.selectDirectorFileButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Director Picture";
            // 
            // director
            // 
            this.director.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.director.Location = new System.Drawing.Point(19, 239);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(196, 189);
            this.director.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.director.TabIndex = 0;
            this.director.TabStop = false;
            // 
            // uploadPosterButton
            // 
            this.uploadPosterButton.Location = new System.Drawing.Point(280, 170);
            this.uploadPosterButton.Name = "uploadPosterButton";
            this.uploadPosterButton.Size = new System.Drawing.Size(75, 23);
            this.uploadPosterButton.TabIndex = 8;
            this.uploadPosterButton.Text = "Upload";
            this.uploadPosterButton.UseVisualStyleBackColor = true;
            this.uploadPosterButton.Click += new System.EventHandler(this.uploadPosterButton_Click);
            // 
            // selectPosterFileButton
            // 
            this.selectPosterFileButton.Location = new System.Drawing.Point(280, 141);
            this.selectPosterFileButton.Name = "selectPosterFileButton";
            this.selectPosterFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectPosterFileButton.TabIndex = 7;
            this.selectPosterFileButton.Text = "Select File";
            this.selectPosterFileButton.UseVisualStyleBackColor = true;
            this.selectPosterFileButton.Click += new System.EventHandler(this.selectPosterFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poster";
            // 
            // poster
            // 
            this.poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poster.Location = new System.Drawing.Point(19, 50);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(255, 143);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster.TabIndex = 0;
            this.poster.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trailer Uploaded:";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveDirectorButton);
            this.groupBox3.Controls.Add(this.Bio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Origin);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(713, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 311);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Director";
            // 
            // saveDirectorButton
            // 
            this.saveDirectorButton.Location = new System.Drawing.Point(291, 271);
            this.saveDirectorButton.Name = "saveDirectorButton";
            this.saveDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.saveDirectorButton.TabIndex = 4;
            this.saveDirectorButton.Text = "Save";
            this.saveDirectorButton.UseVisualStyleBackColor = true;
            this.saveDirectorButton.Click += new System.EventHandler(this.saveDirectorButton_Click);
            // 
            // Bio
            // 
            this.Bio.Location = new System.Drawing.Point(28, 103);
            this.Bio.Multiline = true;
            this.Bio.Name = "Bio";
            this.Bio.Size = new System.Drawing.Size(338, 151);
            this.Bio.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bio";
            // 
            // Origin
            // 
            this.Origin.Location = new System.Drawing.Point(28, 47);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(231, 23);
            this.Origin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Origin";
            // 
            // FilmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmDetails";
            this.Load += new System.EventHandler(this.FilmDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.still3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.still2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.still1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.director)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FilmTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Button uploadPosterButton;
        private System.Windows.Forms.Button selectPosterFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button uploadDirectorButton;
        private System.Windows.Forms.Button selectDirectorFileButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox director;
        private System.Windows.Forms.Button saveFilmDetailsButton;
        private System.Windows.Forms.TextBox Synopsis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FilmLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveDirectorButton;
        private System.Windows.Forms.TextBox Bio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Origin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox still3;
        private System.Windows.Forms.PictureBox still2;
        private System.Windows.Forms.PictureBox still1;
        private System.Windows.Forms.Button still2UploadtButton;
        private System.Windows.Forms.Button still2SelectButton;
        private System.Windows.Forms.Button still3UploadtButton;
        private System.Windows.Forms.Button still3SelectButton;
        private System.Windows.Forms.Button still1UploadtButton;
        private System.Windows.Forms.Button still1SelectButton;
        private System.Windows.Forms.CheckBox FirstFilm;
        private System.Windows.Forms.ComboBox Screens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TrailerUploaded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uploadTrailerButton;
        private System.Windows.Forms.Button selectTrailerButton;
    }
}