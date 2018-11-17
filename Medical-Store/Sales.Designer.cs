namespace Medical_Store
{
    partial class Sales
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
            this.SalesTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabSales = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.chkEdit = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.txtPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtQty = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtCustomer = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.gv = new System.Windows.Forms.DataGridView();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbMedicine = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtContact = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvailableStock = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.SalesTab.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesTab
            // 
            this.SalesTab.Controls.Add(this.tabSales);
            this.SalesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SalesTab.ItemSize = new System.Drawing.Size(100, 38);
            this.SalesTab.Location = new System.Drawing.Point(38, 96);
            this.SalesTab.Name = "SalesTab";
            this.SalesTab.SelectedIndex = 0;
            this.SalesTab.Size = new System.Drawing.Size(1226, 595);
            this.SalesTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.SalesTab.Speed = 20;
            this.SalesTab.Style = MetroSet_UI.Design.Style.Light;
            this.SalesTab.StyleManager = null;
            this.SalesTab.TabIndex = 0;
            this.SalesTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.SalesTab.ThemeAuthor = "Narwin";
            this.SalesTab.ThemeName = "MetroLite";
            this.SalesTab.UseAnimation = true;
            // 
            // tabSales
            // 
            this.tabSales.BaseColor = System.Drawing.Color.White;
            this.tabSales.Controls.Add(this.metroSetLabel8);
            this.tabSales.Controls.Add(this.lblAvailableStock);
            this.tabSales.Controls.Add(this.metroSetLabel7);
            this.tabSales.Controls.Add(this.lblTotal);
            this.tabSales.Controls.Add(this.chkEdit);
            this.tabSales.Controls.Add(this.txtPrice);
            this.tabSales.Controls.Add(this.txtQty);
            this.tabSales.Controls.Add(this.txtCustomer);
            this.tabSales.Controls.Add(this.btnAdd);
            this.tabSales.Controls.Add(this.gv);
            this.tabSales.Controls.Add(this.metroSetLabel3);
            this.tabSales.Controls.Add(this.metroSetLabel4);
            this.tabSales.Controls.Add(this.cmbMedicine);
            this.tabSales.Controls.Add(this.metroSetLabel5);
            this.tabSales.Controls.Add(this.metroSetLabel2);
            this.tabSales.Controls.Add(this.txtContact);
            this.tabSales.Controls.Add(this.metroSetLabel1);
            this.tabSales.Controls.Add(this.btnSave);
            this.tabSales.ImageIndex = 0;
            this.tabSales.ImageKey = null;
            this.tabSales.Location = new System.Drawing.Point(4, 42);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(1218, 549);
            this.tabSales.Style = MetroSet_UI.Design.Style.Light;
            this.tabSales.StyleManager = null;
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.ThemeAuthor = "Narwin";
            this.tabSales.ThemeName = "MetroLite";
            this.tabSales.ToolTipText = null;
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.Location = new System.Drawing.Point(1058, 306);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(51, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 33;
            this.metroSetLabel7.Text = "Total :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(1115, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.Style = MetroSet_UI.Design.Style.Light;
            this.lblTotal.StyleManager = null;
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "0";
            this.lblTotal.ThemeAuthor = "Narwin";
            this.lblTotal.ThemeName = "MetroLite";
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
            this.chkEdit.Location = new System.Drawing.Point(838, 30);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chkEdit.Size = new System.Drawing.Size(75, 16);
            this.chkEdit.Style = MetroSet_UI.Design.Style.Light;
            this.chkEdit.StyleManager = null;
            this.chkEdit.TabIndex = 31;
            this.chkEdit.Text = "Edit";
            this.chkEdit.ThemeAuthor = "Narwin";
            this.chkEdit.ThemeName = "MetroLite";
            this.chkEdit.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.chkEdit_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteCustomSource = null;
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPrice.Image = null;
            this.txtPrice.Lines = null;
            this.txtPrice.Location = new System.Drawing.Point(14, 201);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(384, 26);
            this.txtPrice.Style = MetroSet_UI.Design.Style.Light;
            this.txtPrice.StyleManager = null;
            this.txtPrice.TabIndex = 30;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.ThemeAuthor = "Narwin";
            this.txtPrice.ThemeName = "MetroLite";
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.WatermarkText = "";
            // 
            // txtQty
            // 
            this.txtQty.AutoCompleteCustomSource = null;
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQty.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQty.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQty.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQty.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQty.Image = null;
            this.txtQty.Lines = null;
            this.txtQty.Location = new System.Drawing.Point(430, 124);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = false;
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(384, 26);
            this.txtQty.Style = MetroSet_UI.Design.Style.Light;
            this.txtQty.StyleManager = null;
            this.txtQty.TabIndex = 29;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.ThemeAuthor = "Narwin";
            this.txtQty.ThemeName = "MetroLite";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WatermarkText = "";
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoCompleteCustomSource = null;
            this.txtCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCustomer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCustomer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCustomer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCustomer.Image = null;
            this.txtCustomer.Lines = null;
            this.txtCustomer.Location = new System.Drawing.Point(14, 56);
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.Multiline = false;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = false;
            this.txtCustomer.Size = new System.Drawing.Size(384, 26);
            this.txtCustomer.Style = MetroSet_UI.Design.Style.Light;
            this.txtCustomer.StyleManager = null;
            this.txtCustomer.TabIndex = 28;
            this.txtCustomer.Text = "Customer";
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomer.ThemeAuthor = "Narwin";
            this.txtCustomer.ThemeName = "MetroLite";
            this.txtCustomer.UseSystemPasswordChar = false;
            this.txtCustomer.WatermarkText = "";
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(700, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdd.PressTextColor = System.Drawing.Color.White;
            this.btnAdd.Size = new System.Drawing.Size(114, 37);
            this.btnAdd.Style = MetroSet_UI.Design.Style.Light;
            this.btnAdd.StyleManager = null;
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.ThemeAuthor = "Narwin";
            this.btnAdd.ThemeName = "MetroLite";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.qty,
            this.price,
            this.total,
            this.expiry});
            this.gv.Location = new System.Drawing.Point(838, 52);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(377, 233);
            this.gv.TabIndex = 26;
            this.gv.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gv_UserDeletingRow);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(14, 174);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 24;
            this.metroSetLabel3.Text = "Rate";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(430, 98);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 22;
            this.metroSetLabel4.Text = "Qty";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.AllowDrop = true;
            this.cmbMedicine.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMedicine.BackColor = System.Drawing.Color.Transparent;
            this.cmbMedicine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbMedicine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMedicine.CausesValidation = false;
            this.cmbMedicine.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbMedicine.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbMedicine.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbMedicine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.ItemHeight = 20;
            this.cmbMedicine.Location = new System.Drawing.Point(14, 124);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbMedicine.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbMedicine.Size = new System.Drawing.Size(384, 26);
            this.cmbMedicine.Style = MetroSet_UI.Design.Style.Light;
            this.cmbMedicine.StyleManager = null;
            this.cmbMedicine.TabIndex = 21;
            this.cmbMedicine.ThemeAuthor = "Narwin";
            this.cmbMedicine.ThemeName = "MetroLite";
            this.cmbMedicine.SelectionChangeCommitted += new System.EventHandler(this.cmbMedicine_SelectionChangeCommitted);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.Location = new System.Drawing.Point(14, 98);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 20;
            this.metroSetLabel5.Text = "Medicine Name";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(430, 30);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 19;
            this.metroSetLabel2.Text = "Contact Number";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // txtContact
            // 
            this.txtContact.AutoCompleteCustomSource = null;
            this.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContact.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContact.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtContact.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtContact.Image = null;
            this.txtContact.Lines = null;
            this.txtContact.Location = new System.Drawing.Point(430, 56);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = false;
            this.txtContact.Size = new System.Drawing.Size(384, 26);
            this.txtContact.Style = MetroSet_UI.Design.Style.Light;
            this.txtContact.StyleManager = null;
            this.txtContact.TabIndex = 18;
            this.txtContact.Text = "9999999999";
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContact.ThemeAuthor = "Narwin";
            this.txtContact.ThemeName = "MetroLite";
            this.txtContact.UseSystemPasswordChar = false;
            this.txtContact.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(14, 30);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 16;
            this.metroSetLabel1.Text = "Customer Name";
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
            this.btnSave.Location = new System.Drawing.Point(838, 349);
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
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLite";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // productID
            // 
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Medicine";
            this.productName.Name = "productName";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "Rate";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // expiry
            // 
            this.expiry.HeaderText = "expiry";
            this.expiry.Name = "expiry";
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAvailableStock.Location = new System.Drawing.Point(297, 157);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(100, 23);
            this.lblAvailableStock.Style = MetroSet_UI.Design.Style.Light;
            this.lblAvailableStock.StyleManager = null;
            this.lblAvailableStock.TabIndex = 34;
            this.lblAvailableStock.Text = "0";
            this.lblAvailableStock.ThemeAuthor = "Narwin";
            this.lblAvailableStock.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.Location = new System.Drawing.Point(177, 157);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(114, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 35;
            this.metroSetLabel8.Text = "Available Stock : ";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.SalesTab);
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SalesTab.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl SalesTab;
        private MetroSet_UI.Child.MetroSetTabPage tabSales;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtContact;
        private System.Windows.Forms.DataGridView gv;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetComboBox cmbMedicine;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetButton btnAdd;
        private MetroSet_UI.Controls.MetroSetTextBox txtPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtQty;
        private MetroSet_UI.Controls.MetroSetTextBox txtCustomer;
        private MetroSet_UI.Controls.MetroSetCheckBox chkEdit;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiry;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel lblAvailableStock;
    }
}