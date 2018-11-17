namespace Medical_Store
{
    partial class Purchase
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
            this.PurchaseTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPurchase = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbMedicine = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tabStock = new MetroSet_UI.Child.MetroSetTabPage();
            this.gv = new System.Windows.Forms.DataGridView();
            this.txtQty = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtSalPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PurchaseTab.SuspendLayout();
            this.tabPurchase.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseTab
            // 
            this.PurchaseTab.Controls.Add(this.tabPurchase);
            this.PurchaseTab.Controls.Add(this.tabStock);
            this.PurchaseTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.PurchaseTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PurchaseTab.ItemSize = new System.Drawing.Size(100, 38);
            this.PurchaseTab.Location = new System.Drawing.Point(40, 90);
            this.PurchaseTab.Name = "PurchaseTab";
            this.PurchaseTab.SelectedIndex = 0;
            this.PurchaseTab.Size = new System.Drawing.Size(1226, 595);
            this.PurchaseTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PurchaseTab.Speed = 20;
            this.PurchaseTab.Style = MetroSet_UI.Design.Style.Light;
            this.PurchaseTab.StyleManager = null;
            this.PurchaseTab.TabIndex = 1000;
            this.PurchaseTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.PurchaseTab.ThemeAuthor = "Narwin";
            this.PurchaseTab.ThemeName = "MetroLite";
            this.PurchaseTab.UseAnimation = false;
            this.PurchaseTab.SelectedIndexChanged += new System.EventHandler(this.PurchaseTab_SelectedIndexChanged);
            // 
            // tabPurchase
            // 
            this.tabPurchase.BaseColor = System.Drawing.Color.White;
            this.tabPurchase.Controls.Add(this.txtSalPrice);
            this.tabPurchase.Controls.Add(this.txtPrice);
            this.tabPurchase.Controls.Add(this.txtQty);
            this.tabPurchase.Controls.Add(this.btnSave);
            this.tabPurchase.Controls.Add(this.dtpExpiry);
            this.tabPurchase.Controls.Add(this.metroSetLabel5);
            this.tabPurchase.Controls.Add(this.metroSetLabel4);
            this.tabPurchase.Controls.Add(this.metroSetLabel3);
            this.tabPurchase.Controls.Add(this.metroSetLabel2);
            this.tabPurchase.Controls.Add(this.cmbMedicine);
            this.tabPurchase.Controls.Add(this.metroSetLabel1);
            this.tabPurchase.ImageIndex = 0;
            this.tabPurchase.ImageKey = null;
            this.tabPurchase.Location = new System.Drawing.Point(4, 42);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Size = new System.Drawing.Size(1218, 549);
            this.tabPurchase.Style = MetroSet_UI.Design.Style.Light;
            this.tabPurchase.StyleManager = null;
            this.tabPurchase.TabIndex = 0;
            this.tabPurchase.Text = "Stock Entry";
            this.tabPurchase.ThemeAuthor = "Narwin";
            this.tabPurchase.ThemeName = "MetroLite";
            this.tabPurchase.ToolTipText = null;
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
            this.btnSave.Location = new System.Drawing.Point(303, 402);
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
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLite";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(33, 344);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(384, 23);
            this.dtpExpiry.TabIndex = 10;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.Location = new System.Drawing.Point(33, 317);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 13;
            this.metroSetLabel5.Text = "Expiry Date";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.Location = new System.Drawing.Point(33, 243);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 11;
            this.metroSetLabel4.Text = "Sales Price";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(33, 171);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 9;
            this.metroSetLabel3.Text = "Purchase Price";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(33, 105);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 7;
            this.metroSetLabel2.Text = "Quantity";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
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
            this.cmbMedicine.Location = new System.Drawing.Point(33, 66);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbMedicine.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbMedicine.Size = new System.Drawing.Size(384, 26);
            this.cmbMedicine.Style = MetroSet_UI.Design.Style.Light;
            this.cmbMedicine.StyleManager = null;
            this.cmbMedicine.TabIndex = 6;
            this.cmbMedicine.ThemeAuthor = "Narwin";
            this.cmbMedicine.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(33, 40);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(384, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Medicine Name";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tabStock
            // 
            this.tabStock.BaseColor = System.Drawing.Color.White;
            this.tabStock.Controls.Add(this.gv);
            this.tabStock.ImageIndex = 0;
            this.tabStock.ImageKey = null;
            this.tabStock.Location = new System.Drawing.Point(4, 42);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(1218, 549);
            this.tabStock.Style = MetroSet_UI.Design.Style.Light;
            this.tabStock.StyleManager = null;
            this.tabStock.TabIndex = 1;
            this.tabStock.Text = "Stock";
            this.tabStock.ThemeAuthor = "Narwin";
            this.tabStock.ThemeName = "MetroLite";
            this.tabStock.ToolTipText = null;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(17, 36);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.Size = new System.Drawing.Size(1196, 514);
            this.gv.TabIndex = 0;
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
            this.txtQty.Location = new System.Drawing.Point(33, 132);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = false;
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(384, 26);
            this.txtQty.Style = MetroSet_UI.Design.Style.Light;
            this.txtQty.StyleManager = null;
            this.txtQty.TabIndex = 7;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.ThemeAuthor = "Narwin";
            this.txtQty.ThemeName = "MetroLite";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WatermarkText = "";
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
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPrice.Image = null;
            this.txtPrice.Lines = null;
            this.txtPrice.Location = new System.Drawing.Point(33, 197);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(384, 26);
            this.txtPrice.Style = MetroSet_UI.Design.Style.Light;
            this.txtPrice.StyleManager = null;
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.ThemeAuthor = "Narwin";
            this.txtPrice.ThemeName = "MetroLite";
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.WatermarkText = "";
            // 
            // txtSalPrice
            // 
            this.txtSalPrice.AutoCompleteCustomSource = null;
            this.txtSalPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSalPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSalPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSalPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSalPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSalPrice.Image = null;
            this.txtSalPrice.Lines = null;
            this.txtSalPrice.Location = new System.Drawing.Point(33, 269);
            this.txtSalPrice.MaxLength = 32767;
            this.txtSalPrice.Multiline = false;
            this.txtSalPrice.Name = "txtSalPrice";
            this.txtSalPrice.ReadOnly = false;
            this.txtSalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSalPrice.Size = new System.Drawing.Size(384, 26);
            this.txtSalPrice.Style = MetroSet_UI.Design.Style.Light;
            this.txtSalPrice.StyleManager = null;
            this.txtSalPrice.TabIndex = 9;
            this.txtSalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSalPrice.ThemeAuthor = "Narwin";
            this.txtSalPrice.ThemeName = "MetroLite";
            this.txtSalPrice.UseSystemPasswordChar = false;
            this.txtSalPrice.WatermarkText = "";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.PurchaseTab);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PurchaseTab.ResumeLayout(false);
            this.tabPurchase.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl PurchaseTab;
        private MetroSet_UI.Child.MetroSetTabPage tabPurchase;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetComboBox cmbMedicine;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Child.MetroSetTabPage tabStock;
        private System.Windows.Forms.DataGridView gv;
        private MetroSet_UI.Controls.MetroSetTextBox txtSalPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtQty;
    }
}