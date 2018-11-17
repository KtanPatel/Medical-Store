namespace Medical_Store
{
    partial class Medicine
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
            this.MedicineTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabAddMedicine = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbUnit = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbCompany = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtDesc = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbCategory = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabMedicineList = new MetroSet_UI.Child.MetroSetTabPage();
            this.chkEdit = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.MedicineTab.SuspendLayout();
            this.tabAddMedicine.SuspendLayout();
            this.tabMedicineList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineTab
            // 
            this.MedicineTab.Controls.Add(this.tabAddMedicine);
            this.MedicineTab.Controls.Add(this.tabMedicineList);
            this.MedicineTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicineTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MedicineTab.ItemSize = new System.Drawing.Size(100, 38);
            this.MedicineTab.Location = new System.Drawing.Point(31, 87);
            this.MedicineTab.Name = "MedicineTab";
            this.MedicineTab.SelectedIndex = 1;
            this.MedicineTab.Size = new System.Drawing.Size(1226, 595);
            this.MedicineTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MedicineTab.Speed = 20;
            this.MedicineTab.Style = MetroSet_UI.Design.Style.Light;
            this.MedicineTab.StyleManager = null;
            this.MedicineTab.TabIndex = 999;
            this.MedicineTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.MedicineTab.ThemeAuthor = "Narwin";
            this.MedicineTab.ThemeName = "MetroLite";
            this.MedicineTab.UseAnimation = false;
            this.MedicineTab.SelectedIndexChanged += new System.EventHandler(this.MedicineTab_SelectedIndexChanged);
            // 
            // tabAddMedicine
            // 
            this.tabAddMedicine.BaseColor = System.Drawing.Color.White;
            this.tabAddMedicine.Controls.Add(this.btnSave);
            this.tabAddMedicine.Controls.Add(this.metroSetLabel5);
            this.tabAddMedicine.Controls.Add(this.cmbUnit);
            this.tabAddMedicine.Controls.Add(this.metroSetLabel4);
            this.tabAddMedicine.Controls.Add(this.cmbCompany);
            this.tabAddMedicine.Controls.Add(this.metroSetLabel3);
            this.tabAddMedicine.Controls.Add(this.txtDesc);
            this.tabAddMedicine.Controls.Add(this.metroSetLabel2);
            this.tabAddMedicine.Controls.Add(this.cmbCategory);
            this.tabAddMedicine.Controls.Add(this.metroSetLabel1);
            this.tabAddMedicine.Controls.Add(this.txtName);
            this.tabAddMedicine.ImageIndex = 0;
            this.tabAddMedicine.ImageKey = null;
            this.tabAddMedicine.Location = new System.Drawing.Point(4, 42);
            this.tabAddMedicine.Name = "tabAddMedicine";
            this.tabAddMedicine.Size = new System.Drawing.Size(1218, 549);
            this.tabAddMedicine.Style = MetroSet_UI.Design.Style.Light;
            this.tabAddMedicine.StyleManager = null;
            this.tabAddMedicine.TabIndex = 0;
            this.tabAddMedicine.Text = "Add Medicine";
            this.tabAddMedicine.ThemeAuthor = "Narwin";
            this.tabAddMedicine.ThemeName = "MetroLite";
            this.tabAddMedicine.ToolTipText = null;
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
            this.btnSave.Location = new System.Drawing.Point(464, 293);
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
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLite";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.Location = new System.Drawing.Point(41, 184);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 12;
            this.metroSetLabel5.Text = "Unit";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // cmbUnit
            // 
            this.cmbUnit.AllowDrop = true;
            this.cmbUnit.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbUnit.CausesValidation = false;
            this.cmbUnit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbUnit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbUnit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.ItemHeight = 20;
            this.cmbUnit.Items.AddRange(new object[] {
            "BOX",
            "NOS",
            "PKT"});
            this.cmbUnit.Location = new System.Drawing.Point(41, 210);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbUnit.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbUnit.Size = new System.Drawing.Size(384, 26);
            this.cmbUnit.Sorted = true;
            this.cmbUnit.Style = MetroSet_UI.Design.Style.Light;
            this.cmbUnit.StyleManager = null;
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.ThemeAuthor = "Narwin";
            this.cmbUnit.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(464, 116);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 10;
            this.metroSetLabel4.Text = "Company";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // cmbCompany
            // 
            this.cmbCompany.AllowDrop = true;
            this.cmbCompany.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCompany.BackColor = System.Drawing.Color.Transparent;
            this.cmbCompany.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbCompany.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCompany.CausesValidation = false;
            this.cmbCompany.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbCompany.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbCompany.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.ItemHeight = 20;
            this.cmbCompany.Location = new System.Drawing.Point(464, 142);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbCompany.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbCompany.Size = new System.Drawing.Size(384, 26);
            this.cmbCompany.Style = MetroSet_UI.Design.Style.Light;
            this.cmbCompany.StyleManager = null;
            this.cmbCompany.TabIndex = 3;
            this.cmbCompany.ThemeAuthor = "Narwin";
            this.cmbCompany.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(464, 43);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 8;
            this.metroSetLabel3.Text = "Description (optional)";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // txtDesc
            // 
            this.txtDesc.AutoCompleteCustomSource = null;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDesc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDesc.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDesc.Image = null;
            this.txtDesc.Lines = null;
            this.txtDesc.Location = new System.Drawing.Point(464, 69);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = false;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.Size = new System.Drawing.Size(384, 30);
            this.txtDesc.Style = MetroSet_UI.Design.Style.Light;
            this.txtDesc.StyleManager = null;
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "Description";
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.ThemeAuthor = "Narwin";
            this.txtDesc.ThemeName = "MetroLite";
            this.txtDesc.UseSystemPasswordChar = false;
            this.txtDesc.WatermarkText = "Description";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(41, 116);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 6;
            this.metroSetLabel2.Text = "Category";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AllowDrop = true;
            this.cmbCategory.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCategory.CausesValidation = false;
            this.cmbCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 20;
            this.cmbCategory.Location = new System.Drawing.Point(41, 142);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbCategory.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Size = new System.Drawing.Size(384, 26);
            this.cmbCategory.Style = MetroSet_UI.Design.Style.Light;
            this.cmbCategory.StyleManager = null;
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.ThemeAuthor = "Narwin";
            this.cmbCategory.ThemeName = "MetroLite";
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
            this.metroSetLabel1.Text = "Medicine Name";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
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
            this.txtName.Text = "Medicine Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.ThemeAuthor = "Narwin";
            this.txtName.ThemeName = "MetroLite";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WatermarkText = "Medicine Name";
            // 
            // tabMedicineList
            // 
            this.tabMedicineList.BaseColor = System.Drawing.Color.White;
            this.tabMedicineList.Controls.Add(this.chkEdit);
            this.tabMedicineList.Controls.Add(this.gv);
            this.tabMedicineList.ImageIndex = 0;
            this.tabMedicineList.ImageKey = null;
            this.tabMedicineList.Location = new System.Drawing.Point(4, 42);
            this.tabMedicineList.Name = "tabMedicineList";
            this.tabMedicineList.Size = new System.Drawing.Size(1218, 549);
            this.tabMedicineList.Style = MetroSet_UI.Design.Style.Light;
            this.tabMedicineList.StyleManager = null;
            this.tabMedicineList.TabIndex = 1;
            this.tabMedicineList.Text = "Medicine List";
            this.tabMedicineList.ThemeAuthor = "Narwin";
            this.tabMedicineList.ThemeName = "MetroLite";
            this.tabMedicineList.ToolTipText = null;
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
            this.chkEdit.Location = new System.Drawing.Point(19, 4);
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
            this.gv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(19, 32);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(1196, 514);
            this.gv.TabIndex = 0;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            this.gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEndEdit);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.MedicineTab);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MedicineTab.ResumeLayout(false);
            this.tabAddMedicine.ResumeLayout(false);
            this.tabMedicineList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl MedicineTab;
        private MetroSet_UI.Child.MetroSetTabPage tabAddMedicine;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtName;
        private MetroSet_UI.Child.MetroSetTabPage tabMedicineList;
        private System.Windows.Forms.DataGridView gv;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCategory;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCompany;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txtDesc;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetComboBox cmbUnit;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetCheckBox chkEdit;
    }
}