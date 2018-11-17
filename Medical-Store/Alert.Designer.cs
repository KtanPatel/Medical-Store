namespace Medical_Store
{
    partial class Alert
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
            this.AlertTab = new MetroSet_UI.Controls.MetroSetTabControl();
            this.expiryAlertTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.stockAlertTab = new MetroSet_UI.Child.MetroSetTabPage();
            this.gvStock = new System.Windows.Forms.DataGridView();
            this.gvExpire = new System.Windows.Forms.DataGridView();
            this.txtDays = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnSearchE = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnSearchS = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.txtCount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.AlertTab.SuspendLayout();
            this.expiryAlertTab.SuspendLayout();
            this.stockAlertTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpire)).BeginInit();
            this.SuspendLayout();
            // 
            // AlertTab
            // 
            this.AlertTab.Controls.Add(this.expiryAlertTab);
            this.AlertTab.Controls.Add(this.stockAlertTab);
            this.AlertTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.AlertTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.AlertTab.ItemSize = new System.Drawing.Size(100, 38);
            this.AlertTab.Location = new System.Drawing.Point(31, 98);
            this.AlertTab.Name = "AlertTab";
            this.AlertTab.SelectedIndex = 0;
            this.AlertTab.Size = new System.Drawing.Size(1226, 595);
            this.AlertTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AlertTab.Speed = 20;
            this.AlertTab.Style = MetroSet_UI.Design.Style.Light;
            this.AlertTab.StyleManager = null;
            this.AlertTab.TabIndex = 1;
            this.AlertTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.AlertTab.ThemeAuthor = "Narwin";
            this.AlertTab.ThemeName = "MetroLite";
            this.AlertTab.UseAnimation = false;
            this.AlertTab.SelectedIndexChanged += new System.EventHandler(this.AlertTab_SelectedIndexChanged);
            // 
            // expiryAlertTab
            // 
            this.expiryAlertTab.BaseColor = System.Drawing.Color.White;
            this.expiryAlertTab.Controls.Add(this.btnSearchE);
            this.expiryAlertTab.Controls.Add(this.txtDays);
            this.expiryAlertTab.Controls.Add(this.gvExpire);
            this.expiryAlertTab.ImageIndex = 0;
            this.expiryAlertTab.ImageKey = null;
            this.expiryAlertTab.Location = new System.Drawing.Point(4, 42);
            this.expiryAlertTab.Name = "expiryAlertTab";
            this.expiryAlertTab.Size = new System.Drawing.Size(1218, 549);
            this.expiryAlertTab.Style = MetroSet_UI.Design.Style.Light;
            this.expiryAlertTab.StyleManager = null;
            this.expiryAlertTab.TabIndex = 0;
            this.expiryAlertTab.Text = "Expiry Alert";
            this.expiryAlertTab.ThemeAuthor = "Narwin";
            this.expiryAlertTab.ThemeName = "MetroLite";
            this.expiryAlertTab.ToolTipText = null;
            // 
            // stockAlertTab
            // 
            this.stockAlertTab.BaseColor = System.Drawing.Color.White;
            this.stockAlertTab.Controls.Add(this.btnSearchS);
            this.stockAlertTab.Controls.Add(this.txtCount);
            this.stockAlertTab.Controls.Add(this.gvStock);
            this.stockAlertTab.ImageIndex = 0;
            this.stockAlertTab.ImageKey = null;
            this.stockAlertTab.Location = new System.Drawing.Point(4, 42);
            this.stockAlertTab.Name = "stockAlertTab";
            this.stockAlertTab.Size = new System.Drawing.Size(1218, 549);
            this.stockAlertTab.Style = MetroSet_UI.Design.Style.Light;
            this.stockAlertTab.StyleManager = null;
            this.stockAlertTab.TabIndex = 1;
            this.stockAlertTab.Text = "Stock Alert";
            this.stockAlertTab.ThemeAuthor = "Narwin";
            this.stockAlertTab.ThemeName = "MetroLite";
            this.stockAlertTab.ToolTipText = null;
            // 
            // gvStock
            // 
            this.gvStock.AllowUserToAddRows = false;
            this.gvStock.AllowUserToDeleteRows = false;
            this.gvStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStock.Location = new System.Drawing.Point(19, 32);
            this.gvStock.Name = "gvStock";
            this.gvStock.Size = new System.Drawing.Size(1196, 400);
            this.gvStock.TabIndex = 0;
            // 
            // gvExpire
            // 
            this.gvExpire.AllowUserToAddRows = false;
            this.gvExpire.AllowUserToDeleteRows = false;
            this.gvExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExpire.Location = new System.Drawing.Point(19, 32);
            this.gvExpire.Name = "gvExpire";
            this.gvExpire.Size = new System.Drawing.Size(1196, 400);
            this.gvExpire.TabIndex = 1;
            this.gvExpire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExpire_CellClick);
            // 
            // txtDays
            // 
            this.txtDays.AutoCompleteCustomSource = null;
            this.txtDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDays.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDays.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDays.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDays.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDays.Image = null;
            this.txtDays.Lines = null;
            this.txtDays.Location = new System.Drawing.Point(19, 3);
            this.txtDays.MaxLength = 32767;
            this.txtDays.Multiline = false;
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = false;
            this.txtDays.Size = new System.Drawing.Size(135, 23);
            this.txtDays.Style = MetroSet_UI.Design.Style.Light;
            this.txtDays.StyleManager = null;
            this.txtDays.TabIndex = 2;
            this.txtDays.Text = "45";
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDays.ThemeAuthor = "Narwin";
            this.txtDays.ThemeName = "MetroLite";
            this.txtDays.UseSystemPasswordChar = false;
            this.txtDays.WatermarkText = "Days";
            // 
            // btnSearchE
            // 
            this.btnSearchE.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchE.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSearchE.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnSearchE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearchE.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSearchE.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSearchE.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchE.Location = new System.Drawing.Point(160, 3);
            this.btnSearchE.Name = "btnSearchE";
            this.btnSearchE.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchE.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearchE.NormalTextColor = System.Drawing.Color.Black;
            this.btnSearchE.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSearchE.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSearchE.PressTextColor = System.Drawing.Color.White;
            this.btnSearchE.Size = new System.Drawing.Size(75, 23);
            this.btnSearchE.Style = MetroSet_UI.Design.Style.Light;
            this.btnSearchE.StyleManager = null;
            this.btnSearchE.TabIndex = 3;
            this.btnSearchE.Text = "Search";
            this.btnSearchE.ThemeAuthor = "Narwin";
            this.btnSearchE.ThemeName = "MetroLite";
            this.btnSearchE.Click += new System.EventHandler(this.btnSearchE_Click);
            // 
            // btnSearchS
            // 
            this.btnSearchS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSearchS.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnSearchS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearchS.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSearchS.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSearchS.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchS.Location = new System.Drawing.Point(160, 3);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchS.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearchS.NormalTextColor = System.Drawing.Color.Black;
            this.btnSearchS.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSearchS.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSearchS.PressTextColor = System.Drawing.Color.White;
            this.btnSearchS.Size = new System.Drawing.Size(75, 23);
            this.btnSearchS.Style = MetroSet_UI.Design.Style.Light;
            this.btnSearchS.StyleManager = null;
            this.btnSearchS.TabIndex = 5;
            this.btnSearchS.Text = "Search";
            this.btnSearchS.ThemeAuthor = "Narwin";
            this.btnSearchS.ThemeName = "MetroLite";
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // txtCount
            // 
            this.txtCount.AutoCompleteCustomSource = null;
            this.txtCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCount.Image = null;
            this.txtCount.Lines = null;
            this.txtCount.Location = new System.Drawing.Point(19, 3);
            this.txtCount.MaxLength = 32767;
            this.txtCount.Multiline = false;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = false;
            this.txtCount.Size = new System.Drawing.Size(135, 23);
            this.txtCount.Style = MetroSet_UI.Design.Style.Light;
            this.txtCount.StyleManager = null;
            this.txtCount.TabIndex = 4;
            this.txtCount.Text = "10";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCount.ThemeAuthor = "Narwin";
            this.txtCount.ThemeName = "MetroLite";
            this.txtCount.UseSystemPasswordChar = false;
            this.txtCount.WatermarkText = "Stock Count";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.AlertTab);
            this.Name = "Alert";
            this.Text = "Alert";
            this.AlertTab.ResumeLayout(false);
            this.expiryAlertTab.ResumeLayout(false);
            this.stockAlertTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl AlertTab;
        private MetroSet_UI.Child.MetroSetTabPage expiryAlertTab;
        private MetroSet_UI.Child.MetroSetTabPage stockAlertTab;
        private System.Windows.Forms.DataGridView gvStock;
        private System.Windows.Forms.DataGridView gvExpire;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnSearchE;
        private MetroSet_UI.Controls.MetroSetTextBox txtDays;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnSearchS;
        private MetroSet_UI.Controls.MetroSetTextBox txtCount;
    }
}