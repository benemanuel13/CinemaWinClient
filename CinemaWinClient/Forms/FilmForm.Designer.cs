
namespace CinemaWinClient.Forms
{
    partial class FilmForm
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
            this.saveFilm = new System.Windows.Forms.GroupBox();
            this.filmCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editFilmExtras = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.saveFilmDetails = new System.Windows.Forms.Button();
            this.filmTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filmDate = new System.Windows.Forms.DateTimePicker();
            this.filmRating = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filmTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.geoConfirm = new System.Windows.Forms.Button();
            this.geoBlocks = new System.Windows.Forms.TreeView();
            this.saveFilm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFilm
            // 
            this.saveFilm.Controls.Add(this.filmCategories);
            this.saveFilm.Controls.Add(this.label5);
            this.saveFilm.Controls.Add(this.editFilmExtras);
            this.saveFilm.Controls.Add(this.closeForm);
            this.saveFilm.Controls.Add(this.saveFilmDetails);
            this.saveFilm.Controls.Add(this.filmTime);
            this.saveFilm.Controls.Add(this.label4);
            this.saveFilm.Controls.Add(this.label3);
            this.saveFilm.Controls.Add(this.filmDate);
            this.saveFilm.Controls.Add(this.filmRating);
            this.saveFilm.Controls.Add(this.label2);
            this.saveFilm.Controls.Add(this.filmTitle);
            this.saveFilm.Controls.Add(this.label1);
            this.saveFilm.Location = new System.Drawing.Point(12, 12);
            this.saveFilm.Name = "saveFilm";
            this.saveFilm.Size = new System.Drawing.Size(445, 261);
            this.saveFilm.TabIndex = 0;
            this.saveFilm.TabStop = false;
            this.saveFilm.Text = "Film Details";
            // 
            // filmCategories
            // 
            this.filmCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmCategories.FormattingEnabled = true;
            this.filmCategories.Location = new System.Drawing.Point(23, 166);
            this.filmCategories.Name = "filmCategories";
            this.filmCategories.Size = new System.Drawing.Size(224, 23);
            this.filmCategories.TabIndex = 12;
            this.filmCategories.SelectedIndexChanged += new System.EventHandler(this.filmCategories_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Film Category";
            // 
            // editFilmExtras
            // 
            this.editFilmExtras.Enabled = false;
            this.editFilmExtras.Location = new System.Drawing.Point(23, 206);
            this.editFilmExtras.Name = "editFilmExtras";
            this.editFilmExtras.Size = new System.Drawing.Size(131, 23);
            this.editFilmExtras.TabIndex = 10;
            this.editFilmExtras.Text = "Edit Film Extras";
            this.editFilmExtras.UseVisualStyleBackColor = true;
            this.editFilmExtras.Click += new System.EventHandler(this.editFilmExtras_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(347, 206);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(75, 23);
            this.closeForm.TabIndex = 9;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // saveFilmDetails
            // 
            this.saveFilmDetails.Location = new System.Drawing.Point(265, 206);
            this.saveFilmDetails.Name = "saveFilmDetails";
            this.saveFilmDetails.Size = new System.Drawing.Size(75, 23);
            this.saveFilmDetails.TabIndex = 8;
            this.saveFilmDetails.Text = "Save";
            this.saveFilmDetails.UseVisualStyleBackColor = true;
            this.saveFilmDetails.Click += new System.EventHandler(this.saveFilmDetails_Click);
            // 
            // filmTime
            // 
            this.filmTime.CustomFormat = "hh:mm";
            this.filmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filmTime.Location = new System.Drawing.Point(265, 108);
            this.filmTime.Name = "filmTime";
            this.filmTime.ShowUpDown = true;
            this.filmTime.Size = new System.Drawing.Size(157, 23);
            this.filmTime.TabIndex = 7;
            this.filmTime.Value = new System.DateTime(2021, 6, 3, 11, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Showing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Showing";
            // 
            // filmDate
            // 
            this.filmDate.Location = new System.Drawing.Point(23, 108);
            this.filmDate.Name = "filmDate";
            this.filmDate.Size = new System.Drawing.Size(224, 23);
            this.filmDate.TabIndex = 4;
            this.filmDate.Value = new System.DateTime(2021, 6, 3, 11, 0, 0, 0);
            // 
            // filmRating
            // 
            this.filmRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmRating.FormattingEnabled = true;
            this.filmRating.Location = new System.Drawing.Point(265, 50);
            this.filmRating.Name = "filmRating";
            this.filmRating.Size = new System.Drawing.Size(157, 23);
            this.filmRating.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rating";
            // 
            // filmTitle
            // 
            this.filmTitle.Location = new System.Drawing.Point(23, 50);
            this.filmTitle.Name = "filmTitle";
            this.filmTitle.Size = new System.Drawing.Size(224, 23);
            this.filmTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.geoConfirm);
            this.groupBox1.Controls.Add(this.geoBlocks);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geo-Blocking";
            // 
            // geoConfirm
            // 
            this.geoConfirm.Location = new System.Drawing.Point(321, 311);
            this.geoConfirm.Name = "geoConfirm";
            this.geoConfirm.Size = new System.Drawing.Size(101, 23);
            this.geoConfirm.TabIndex = 1;
            this.geoConfirm.Text = "Confirm";
            this.geoConfirm.UseVisualStyleBackColor = true;
            this.geoConfirm.Click += new System.EventHandler(this.geoConfirm_Click);
            // 
            // geoBlocks
            // 
            this.geoBlocks.CheckBoxes = true;
            this.geoBlocks.Location = new System.Drawing.Point(23, 39);
            this.geoBlocks.Name = "geoBlocks";
            this.geoBlocks.Size = new System.Drawing.Size(399, 256);
            this.geoBlocks.TabIndex = 0;
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Film";
            this.Load += new System.EventHandler(this.FilmForm_Load);
            this.saveFilm.ResumeLayout(false);
            this.saveFilm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox saveFilm;
        private System.Windows.Forms.ComboBox filmRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filmTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker filmTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker filmDate;
        private System.Windows.Forms.Button saveFilmDetails;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button geoConfirm;
        private System.Windows.Forms.TreeView geoBlocks;
        private System.Windows.Forms.Button editFilmExtras;
        private System.Windows.Forms.ComboBox filmCategories;
        private System.Windows.Forms.Label label5;
    }
}