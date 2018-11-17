namespace Medical_Store
{
    partial class Company
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
            this.CompanyTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.addCompanyTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.txtContact = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtAddress = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.companyListTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.gv = new System.Windows.Forms.DataGridView();
            this.chkEdit = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.CompanyTab.SuspendLayout();
            this.addCompanyTab.SuspendLayout();
            this.companyListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyTab
            // 
            this.CompanyTab.Controls.Add(this.addCompanyTab);
            this.CompanyTab.Controls.Add(this.companyListTab);
            this.CompanyTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.CompanyTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CompanyTab.ItemSize = new System.Drawing.Size(100, 38);
            this.CompanyTab.Location = new System.Drawing.Point(32, 90);
            this.CompanyTab.Name = "CompanyTab";
            this.CompanyTab.SelectedIndex = 1;
            this.CompanyTab.Size = new System.Drawing.Size(1226, 595);
            this.CompanyTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CompanyTab.Speed = 20;
            this.CompanyTab.Style = MetroSet_UI.Design.Style.Light;
            this.CompanyTab.StyleManager = null;
            this.CompanyTab.TabIndex = 0;
            this.CompanyTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.CompanyTab.ThemeAuthor = "Narwin";
            this.CompanyTab.ThemeName = "MetroLite";
            this.CompanyTab.UseAnimation = false;
            this.CompanyTab.SelectedIndexChanged += new System.EventHandler(this.CompanyTab_SelectedIndexChanged);
            // 
            // addCompanyTab
            // 
            this.addCompanyTab.BaseColor = System.Drawing.Color.White;
            this.addCompanyTab.Controls.Add(this.metroSetLabel3);
            this.addCompanyTab.Controls.Add(this.metroSetLabel2);
            this.addCompanyTab.Controls.Add(this.metroSetLabel1);
            this.addCompanyTab.Controls.Add(this.btnSave);
            this.addCompanyTab.Controls.Add(this.txtContact);
            this.addCompanyTab.Controls.Add(this.txtAddress);
            this.addCompanyTab.Controls.Add(this.txtName);
            this.addCompanyTab.ImageIndex = 0;
            this.addCompanyTab.ImageKey = null;
            this.addCompanyTab.Location = new System.Drawing.Point(4, 42);
            this.addCompanyTab.Name = "addCompanyTab";
            this.addCompanyTab.Size = new System.Drawing.Size(1218, 549);
            this.addCompanyTab.Style = MetroSet_UI.Design.Style.Light;
            this.addCompanyTab.StyleManager = null;
            this.addCompanyTab.TabIndex = 0;
            this.addCompanyTab.Text = "Add Company";
            this.addCompanyTab.ThemeAuthor = "Narwin";
            this.addCompanyTab.ThemeName = "MetroLite";
            this.addCompanyTab.ToolTipText = null;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(41, 235);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 6;
            this.metroSetLabel3.Text = "Contact Number";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
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
            this.metroSetLabel2.Text = "Address";
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
            this.metroSetLabel1.Text = "Company Name";
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
            this.btnSave.Location = new System.Drawing.Point(311, 324);
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
            // txtContact
            // 
            this.txtContact.AutoCompleteCustomSource = null;
            this.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContact.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContact.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtContact.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtContact.Image = null;
            this.txtContact.Lines = null;
            this.txtContact.Location = new System.Drawing.Point(41, 261);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = false;
            this.txtContact.Size = new System.Drawing.Size(384, 30);
            this.txtContact.Style = MetroSet_UI.Design.Style.Light;
            this.txtContact.StyleManager = null;
            this.txtContact.TabIndex = 2;
            this.txtContact.Text = "Contact Number";
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContact.ThemeAuthor = "Narwin";
            this.txtContact.ThemeName = "MetroLite";
            this.txtContact.UseSystemPasswordChar = false;
            this.txtContact.WatermarkText = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoWordSelection = false;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtAddress.Lines = null;
            this.txtAddress.Location = new System.Drawing.Point(41, 146);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(384, 69);
            this.txtAddress.Style = MetroSet_UI.Design.Style.Light;
            this.txtAddress.StyleManager = null;
            this.txtAddress.TabIndex = 1;
            this.txtAddress.ThemeAuthor = "Narwin";
            this.txtAddress.ThemeName = "MetroLite";
            this.txtAddress.WordWrap = true;
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
            this.txtName.Text = "Company Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.ThemeAuthor = "Narwin";
            this.txtName.ThemeName = "MetroLite";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WatermarkText = "Company Name";
            // 
            // companyListTab
            // 
            this.companyListTab.BaseColor = System.Drawing.Color.White;
            this.companyListTab.Controls.Add(this.chkEdit);
            this.companyListTab.Controls.Add(this.gv);
            this.companyListTab.ImageIndex = 0;
            this.companyListTab.ImageKey = null;
            this.companyListTab.Location = new System.Drawing.Point(4, 42);
            this.companyListTab.Name = "companyListTab";
            this.companyListTab.Size = new System.Drawing.Size(1218, 549);
            this.companyListTab.Style = MetroSet_UI.Design.Style.Light;
            this.companyListTab.StyleManager = null;
            this.companyListTab.TabIndex = 1;
            this.companyListTab.Text = "Company List";
            this.companyListTab.ThemeAuthor = "Narwin";
            this.companyListTab.ThemeName = "MetroLite";
            this.companyListTab.ToolTipText = null;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(19, 32);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(1196, 405);
            this.gv.TabIndex = 0;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            this.gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEndEdit);
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
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.CompanyTab);
            this.Name = "Company";
            this.Text = "Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CompanyTab.ResumeLayout(false);
            this.addCompanyTab.ResumeLayout(false);
            this.companyListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl CompanyTab;
        private MetroSet_UI.Child.MetroSetTabPage addCompanyTab;
        private MetroSet_UI.Child.MetroSetTabPage companyListTab;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetTextBox txtContact;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtAddress;
        private MetroSet_UI.Controls.MetroSetTextBox txtName;
        private System.Windows.Forms.DataGridView gv;
        private MetroSet_UI.Controls.MetroSetCheckBox chkEdit;
    }
}