
namespace CinemaWinClient.Forms
{
    partial class MainForm
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
            this.isViewable = new System.Windows.Forms.CheckBox();
            this.cancelFilmCategory = new System.Windows.Forms.Button();
            this.newFilmCategory = new System.Windows.Forms.Button();
            this.filmCategory = new System.Windows.Forms.TextBox();
            this.saveCategory = new System.Windows.Forms.Button();
            this.filmCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uploadFilm = new System.Windows.Forms.Button();
            this.createFilmAsset = new System.Windows.Forms.Button();
            this.deleteFilm = new System.Windows.Forms.Button();
            this.editFilm = new System.Windows.Forms.Button();
            this.addFilm = new System.Windows.Forms.Button();
            this.films = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.filmCollectionDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editCollection = new System.Windows.Forms.Button();
            this.cancelFilmCollection = new System.Windows.Forms.Button();
            this.newFilmCollection = new System.Windows.Forms.Button();
            this.filmCollection = new System.Windows.Forms.TextBox();
            this.saveCollection = new System.Windows.Forms.Button();
            this.filmCollections = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isViewable);
            this.groupBox1.Controls.Add(this.cancelFilmCategory);
            this.groupBox1.Controls.Add(this.newFilmCategory);
            this.groupBox1.Controls.Add(this.filmCategory);
            this.groupBox1.Controls.Add(this.saveCategory);
            this.groupBox1.Controls.Add(this.filmCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Categories";
            // 
            // isViewable
            // 
            this.isViewable.AutoSize = true;
            this.isViewable.Location = new System.Drawing.Point(15, 215);
            this.isViewable.Name = "isViewable";
            this.isViewable.Size = new System.Drawing.Size(84, 19);
            this.isViewable.TabIndex = 6;
            this.isViewable.Text = "Is Viewable";
            this.isViewable.UseVisualStyleBackColor = true;
            this.isViewable.CheckedChanged += new System.EventHandler(this.isViewable_CheckedChanged);
            // 
            // cancelFilmCategory
            // 
            this.cancelFilmCategory.Location = new System.Drawing.Point(177, 246);
            this.cancelFilmCategory.Name = "cancelFilmCategory";
            this.cancelFilmCategory.Size = new System.Drawing.Size(75, 23);
            this.cancelFilmCategory.TabIndex = 5;
            this.cancelFilmCategory.Text = "Cancel";
            this.cancelFilmCategory.UseVisualStyleBackColor = true;
            this.cancelFilmCategory.Click += new System.EventHandler(this.cancelFilmCategory_Click);
            // 
            // newFilmCategory
            // 
            this.newFilmCategory.Location = new System.Drawing.Point(15, 246);
            this.newFilmCategory.Name = "newFilmCategory";
            this.newFilmCategory.Size = new System.Drawing.Size(75, 23);
            this.newFilmCategory.TabIndex = 4;
            this.newFilmCategory.Text = "New";
            this.newFilmCategory.UseVisualStyleBackColor = true;
            this.newFilmCategory.Click += new System.EventHandler(this.newFilmCategory_Click);
            // 
            // filmCategory
            // 
            this.filmCategory.Location = new System.Drawing.Point(15, 182);
            this.filmCategory.Name = "filmCategory";
            this.filmCategory.Size = new System.Drawing.Size(237, 23);
            this.filmCategory.TabIndex = 3;
            this.filmCategory.TextChanged += new System.EventHandler(this.filmCategory_TextChanged);
            // 
            // saveCategory
            // 
            this.saveCategory.Enabled = false;
            this.saveCategory.Location = new System.Drawing.Point(96, 246);
            this.saveCategory.Name = "saveCategory";
            this.saveCategory.Size = new System.Drawing.Size(75, 23);
            this.saveCategory.TabIndex = 2;
            this.saveCategory.Text = "Save";
            this.saveCategory.UseVisualStyleBackColor = true;
            this.saveCategory.Click += new System.EventHandler(this.saveCategory_Click);
            // 
            // filmCategories
            // 
            this.filmCategories.FormattingEnabled = true;
            this.filmCategories.ItemHeight = 15;
            this.filmCategories.Location = new System.Drawing.Point(15, 22);
            this.filmCategories.Name = "filmCategories";
            this.filmCategories.Size = new System.Drawing.Size(237, 154);
            this.filmCategories.TabIndex = 1;
            this.filmCategories.SelectedIndexChanged += new System.EventHandler(this.filmCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uploadFilm);
            this.groupBox2.Controls.Add(this.createFilmAsset);
            this.groupBox2.Controls.Add(this.deleteFilm);
            this.groupBox2.Controls.Add(this.editFilm);
            this.groupBox2.Controls.Add(this.addFilm);
            this.groupBox2.Controls.Add(this.films);
            this.groupBox2.Controls.Add(this.filmCollectionDropdown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Films";
            // 
            // uploadFilm
            // 
            this.uploadFilm.Enabled = false;
            this.uploadFilm.Location = new System.Drawing.Point(475, 229);
            this.uploadFilm.Name = "uploadFilm";
            this.uploadFilm.Size = new System.Drawing.Size(124, 23);
            this.uploadFilm.TabIndex = 7;
            this.uploadFilm.Text = "Upload Film";
            this.uploadFilm.UseVisualStyleBackColor = true;
            this.uploadFilm.Click += new System.EventHandler(this.uploadFilm_Click);
            // 
            // createFilmAsset
            // 
            this.createFilmAsset.Enabled = false;
            this.createFilmAsset.Location = new System.Drawing.Point(605, 229);
            this.createFilmAsset.Name = "createFilmAsset";
            this.createFilmAsset.Size = new System.Drawing.Size(124, 23);
            this.createFilmAsset.TabIndex = 6;
            this.createFilmAsset.Text = "Create Asset";
            this.createFilmAsset.UseVisualStyleBackColor = true;
            // 
            // deleteFilm
            // 
            this.deleteFilm.Location = new System.Drawing.Point(184, 229);
            this.deleteFilm.Name = "deleteFilm";
            this.deleteFilm.Size = new System.Drawing.Size(75, 23);
            this.deleteFilm.TabIndex = 5;
            this.deleteFilm.Text = "Delete";
            this.deleteFilm.UseVisualStyleBackColor = true;
            // 
            // editFilm
            // 
            this.editFilm.Enabled = false;
            this.editFilm.Location = new System.Drawing.Point(103, 229);
            this.editFilm.Name = "editFilm";
            this.editFilm.Size = new System.Drawing.Size(75, 23);
            this.editFilm.TabIndex = 4;
            this.editFilm.Text = "Edit";
            this.editFilm.UseVisualStyleBackColor = true;
            this.editFilm.Click += new System.EventHandler(this.editFilm_Click);
            // 
            // addFilm
            // 
            this.addFilm.Location = new System.Drawing.Point(22, 229);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(75, 23);
            this.addFilm.TabIndex = 3;
            this.addFilm.Text = "Add";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // films
            // 
            this.films.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.films.FullRowSelect = true;
            this.films.GridLines = true;
            this.films.HideSelection = false;
            this.films.Location = new System.Drawing.Point(22, 66);
            this.films.MultiSelect = false;
            this.films.Name = "films";
            this.films.Size = new System.Drawing.Size(707, 155);
            this.films.TabIndex = 2;
            this.films.UseCompatibleStateImageBehavior = false;
            this.films.View = System.Windows.Forms.View.Details;
            this.films.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.films_ColumnClick);
            this.films.SelectedIndexChanged += new System.EventHandler(this.films_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rating";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Showing";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Uploaded?";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Asset Created?";
            this.columnHeader5.Width = 120;
            // 
            // filmCollectionDropdown
            // 
            this.filmCollectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmCollectionDropdown.FormattingEnabled = true;
            this.filmCollectionDropdown.Location = new System.Drawing.Point(22, 37);
            this.filmCollectionDropdown.Name = "filmCollectionDropdown";
            this.filmCollectionDropdown.Size = new System.Drawing.Size(180, 23);
            this.filmCollectionDropdown.TabIndex = 1;
            this.filmCollectionDropdown.SelectedIndexChanged += new System.EventHandler(this.filmCollectionDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Collection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editCollection);
            this.groupBox3.Controls.Add(this.cancelFilmCollection);
            this.groupBox3.Controls.Add(this.newFilmCollection);
            this.groupBox3.Controls.Add(this.filmCollection);
            this.groupBox3.Controls.Add(this.saveCollection);
            this.groupBox3.Controls.Add(this.filmCollections);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(295, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 287);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Collections";
            // 
            // editCollection
            // 
            this.editCollection.Location = new System.Drawing.Point(15, 240);
            this.editCollection.Name = "editCollection";
            this.editCollection.Size = new System.Drawing.Size(75, 23);
            this.editCollection.TabIndex = 6;
            this.editCollection.Text = "Edit";
            this.editCollection.UseVisualStyleBackColor = true;
            this.editCollection.Click += new System.EventHandler(this.editCollection_Click);
            // 
            // cancelFilmCollection
            // 
            this.cancelFilmCollection.Location = new System.Drawing.Point(177, 211);
            this.cancelFilmCollection.Name = "cancelFilmCollection";
            this.cancelFilmCollection.Size = new System.Drawing.Size(75, 23);
            this.cancelFilmCollection.TabIndex = 5;
            this.cancelFilmCollection.Text = "Cancel";
            this.cancelFilmCollection.UseVisualStyleBackColor = true;
            this.cancelFilmCollection.Click += new System.EventHandler(this.cancelFilmCollection_Click);
            // 
            // newFilmCollection
            // 
            this.newFilmCollection.Location = new System.Drawing.Point(15, 211);
            this.newFilmCollection.Name = "newFilmCollection";
            this.newFilmCollection.Size = new System.Drawing.Size(75, 23);
            this.newFilmCollection.TabIndex = 4;
            this.newFilmCollection.Text = "New";
            this.newFilmCollection.UseVisualStyleBackColor = true;
            this.newFilmCollection.Click += new System.EventHandler(this.newFilmCollection_Click);
            // 
            // filmCollection
            // 
            this.filmCollection.Location = new System.Drawing.Point(15, 182);
            this.filmCollection.Name = "filmCollection";
            this.filmCollection.Size = new System.Drawing.Size(237, 23);
            this.filmCollection.TabIndex = 3;
            this.filmCollection.TextChanged += new System.EventHandler(this.filmCollection_TextChanged);
            // 
            // saveCollection
            // 
            this.saveCollection.Enabled = false;
            this.saveCollection.Location = new System.Drawing.Point(96, 211);
            this.saveCollection.Name = "saveCollection";
            this.saveCollection.Size = new System.Drawing.Size(75, 23);
            this.saveCollection.TabIndex = 2;
            this.saveCollection.Text = "Save";
            this.saveCollection.UseVisualStyleBackColor = true;
            this.saveCollection.Click += new System.EventHandler(this.saveCollection_Click);
            // 
            // filmCollections
            // 
            this.filmCollections.FormattingEnabled = true;
            this.filmCollections.ItemHeight = 15;
            this.filmCollections.Location = new System.Drawing.Point(15, 22);
            this.filmCollections.Name = "filmCollections";
            this.filmCollections.Size = new System.Drawing.Size(237, 154);
            this.filmCollections.TabIndex = 1;
            this.filmCollections.SelectedIndexChanged += new System.EventHandler(this.filmCollections_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox filmCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filmCategory;
        private System.Windows.Forms.Button saveCategory;
        private System.Windows.Forms.Button newFilmCategory;
        private System.Windows.Forms.Button cancelFilmCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox filmCollectionDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelFilmCollection;
        private System.Windows.Forms.Button newFilmCollection;
        private System.Windows.Forms.TextBox filmCollection;
        private System.Windows.Forms.Button saveCollection;
        private System.Windows.Forms.ListBox filmCollections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createFilmAsset;
        private System.Windows.Forms.Button deleteFilm;
        private System.Windows.Forms.Button editFilm;
        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.ListView films;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button uploadFilm;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox isViewable;
        private System.Windows.Forms.Button editCollection;
    }
}