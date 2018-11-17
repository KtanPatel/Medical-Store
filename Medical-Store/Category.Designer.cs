namespace Medical_Store
{
    partial class Category
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
            this.CategoryTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.addCategoryTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.txtDescription = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.categoryListTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.chkEdit = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.CategoryTab.SuspendLayout();
            this.addCategoryTab.SuspendLayout();
            this.categoryListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryTab
            // 
            this.CategoryTab.Controls.Add(this.addCategoryTab);
            this.CategoryTab.Controls.Add(this.categoryListTab);
            this.CategoryTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CategoryTab.ItemSize = new System.Drawing.Size(100, 38);
            this.CategoryTab.Location = new System.Drawing.Point(32, 90);
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.SelectedIndex = 1;
            this.CategoryTab.Size = new System.Drawing.Size(1226, 595);
            this.CategoryTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CategoryTab.Speed = 20;
            this.CategoryTab.Style = MetroSet_UI.Design.Style.Light;
            this.CategoryTab.StyleManager = null;
            this.CategoryTab.TabIndex = 0;
            this.CategoryTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.CategoryTab.ThemeAuthor = "Narwin";
            this.CategoryTab.ThemeName = "MetroLite";
            this.CategoryTab.UseAnimation = false;
            this.CategoryTab.SelectedIndexChanged += new System.EventHandler(this.CategoryTab_SelectedIndexChanged);
            // 
            // addCategoryTab
            // 
            this.addCategoryTab.BaseColor = System.Drawing.Color.White;
            this.addCategoryTab.Controls.Add(this.metroSetLabel2);
            this.addCategoryTab.Controls.Add(this.metroSetLabel1);
            this.addCategoryTab.Controls.Add(this.btnSave);
            this.addCategoryTab.Controls.Add(this.txtDescription);
            this.addCategoryTab.Controls.Add(this.txtName);
            this.addCategoryTab.ImageIndex = 0;
            this.addCategoryTab.ImageKey = null;
            this.addCategoryTab.Location = new System.Drawing.Point(4, 42);
            this.addCategoryTab.Name = "addCategoryTab";
            this.addCategoryTab.Size = new System.Drawing.Size(1218, 549);
            this.addCategoryTab.Style = MetroSet_UI.Design.Style.Light;
            this.addCategoryTab.StyleManager = null;
            this.addCategoryTab.TabIndex = 0;
            this.addCategoryTab.Text = "Add Category";
            this.addCategoryTab.ThemeAuthor = "Narwin";
            this.addCategoryTab.ThemeName = "MetroLite";
            this.addCategoryTab.ToolTipText = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(41, 120);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Description (optional)";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(41, 43);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 4;
            this.metroSetLabel1.Text = "Category Name";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // btnSave
            // 
            this.btnSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(311, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalTextColor = System.Drawing.Color.White;
            this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressTextColor = System.Drawing.Color.White;
            this.btnSave.Size = new System.Drawing.Size(114, 37);
            this.btnSave.Style = MetroSet_UI.Design.Style.Light;
            this.btnSave.StyleManager = null;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLite";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoWordSelection = false;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDescription.Lines = null;
            this.txtDescription.Location = new System.Drawing.Point(41, 146);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(384, 69);
            this.txtDescription.Style = MetroSet_UI.Design.Style.Light;
            this.txtDescription.StyleManager = null;
            this.txtDescription.TabIndex = 1;
            this.txtDescription.ThemeAuthor = "Narwin";
            this.txtDescription.ThemeName = "MetroLite";
            this.txtDescription.WordWrap = true;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteCustomSource = null;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtName.Image = null;
            this.txtName.Lines = null;
            this.txtName.Location = new System.Drawing.Point(41, 69);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(384, 30);
            this.txtName.Style = MetroSet_UI.Design.Style.Light;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Category Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.ThemeAuthor = "Narwin";
            this.txtName.ThemeName = "MetroLite";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WatermarkText = "Category Name";
            // 
            // categoryListTab
            // 
            this.categoryListTab.BaseColor = System.Drawing.Color.White;
            this.categoryListTab.Controls.Add(this.chkEdit);
            this.categoryListTab.Controls.Add(this.gv);
            this.categoryListTab.ImageIndex = 0;
            this.categoryListTab.ImageKey = null;
            this.categoryListTab.Location = new System.Drawing.Point(4, 42);
            this.categoryListTab.Name = "categoryListTab";
            this.categoryListTab.Size = new System.Drawing.Size(1218, 549);
            this.categoryListTab.Style = MetroSet_UI.Design.Style.Light;
            this.categoryListTab.StyleManager = null;
            this.categoryListTab.TabIndex = 1;
            this.categoryListTab.Text = "Category List";
            this.categoryListTab.ThemeAuthor = "Narwin";
            this.categoryListTab.ThemeName = "MetroLite";
            this.categoryListTab.ToolTipText = null;
            // 
            // chkEdit
            // 
            this.chkEdit.BackColor = System.Drawing.Color.Transparent;
            this.chkEdit.BackgroundColor = System.Drawing.Color.White;
            this.chkEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chkEdit.Checked = false;
            this.chkEdit.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chkEdit.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chkEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chkEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkEdit.Location = new System.Drawing.Point(19, 10);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chkEdit.Size = new System.Drawing.Size(75, 16);
            this.chkEdit.Style = MetroSet_UI.Design.Style.Light;
            this.chkEdit.StyleManager = null;
            this.chkEdit.TabIndex = 1;
            this.chkEdit.Text = "Edit";
            this.chkEdit.ThemeAuthor = "Narwin";
            this.chkEdit.ThemeName = "MetroLite";
            this.chkEdit.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.chkEdit_CheckedChanged);
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(19, 32);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(1196, 400);
            this.gv.TabIndex = 0;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            this.gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEndEdit);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.CategoryTab);
            this.Name = "Category";
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CategoryTab.ResumeLayout(false);
            this.addCategoryTab.ResumeLayout(false);
            this.categoryListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl CategoryTab;
        private MetroSet_UI.Child.MetroSetTabPage addCategoryTab;
        private MetroSet_UI.Child.MetroSetTabPage categoryListTab;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtName;
        private System.Windows.Forms.DataGridView gv;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtDescription;
        private MetroSet_UI.Controls.MetroSetCheckBox chkEdit;
    }
}