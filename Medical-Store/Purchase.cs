using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Medical_Store.Shared;
namespace Medical_Store
{
    public partial class Purchase : MetroSetForm
    {
        Response res = new Response();
        purchaseController db = new purchaseController();
        public Purchase(int index)
        {
            InitializeComponent();
            PurchaseTab.SelectedIndex = index;
            if (index == 1)
            {
                getStock();

            }
            else
            {
                getMedicine();
            }
        }

        private void getMedicine()
        {
            res = db.getMedicine();
            if (res.success)
            {
                DataSet ds = new DataSet();
                ds = res.data;
                cmbMedicine.DataSource = ds.Tables[0];
                cmbMedicine.DisplayMember = "productName";
                cmbMedicine.ValueMember = "ID";
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Purchase stock = new Shared.Purchase();
            stock.price = Convert.ToDecimal(txtPrice.Text);
            stock.salesPrice = Convert.ToDecimal(txtSalPrice.Text);
            stock.qty = Convert.ToInt32(txtQty.Text);
            stock.expiry = Convert.ToDateTime(dtpExpiry.Value);
            stock.productID = Convert.ToInt32(cmbMedicine.SelectedValue);
            res = db.addStock(stock);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message + " on step number : " + res.data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getStock()
        {
            res = db.getStock();
            if (res.success)
            {
                DataSet ds = res.data;
                gv.Columns.Clear();
                gv.DataSource = ds.Tables[0];
                // gv.EditMode = DataGridViewEditMode.EditOnF2;
                gv.ReadOnly = true;
                gv.Columns[0].Visible = false;
                //DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                //// deleteButton.DisplayIndex = 0;
                //deleteButton.Name = "gvDeleteButton";
                //deleteButton.HeaderText = "Delete";
                //deleteButton.Text = "Delete";
                //deleteButton.UseColumnTextForButtonValue = true;
                //// Deletelink.Text = "DEL";
                //gv.Columns.Add(deleteButton);
                gv.AllowUserToDeleteRows = false;
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PurchaseTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PurchaseTab.SelectedIndex == 1)
            {
                // chkEdit.Checked = false;
                getStock();
            }
            else {
                getMedicine();
            }
        }
    }
}
