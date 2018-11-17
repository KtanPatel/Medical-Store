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
    public partial class Sales : MetroSetForm
    {
        // int rowCount = 0;
        Response res = new Response();
        DataTable dt = new DataTable();
        salesController db = new salesController();
        public Sales()
        {
            InitializeComponent();
            getMedicine();
            chkEdit.Checked = false;
            cmbMedicine.SelectedIndex = -1;
        }

        private void chkEdit_CheckedChanged(object sender)
        {
            if (chkEdit.Checked)
            {
                gv.ReadOnly = false;
                gv.AllowUserToDeleteRows = true;
            }
            else
                gv.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0 && cmbMedicine.SelectedIndex > -1)
            {
                bool flag = false, flag2 = false;
                decimal total = 0;
                if (Convert.ToInt32(txtQty.Text) > Convert.ToInt32(lblAvailableStock.Text))
                {
                    MessageBox.Show("Inputted stock is more then available Stock", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 0; i < gv.Rows.Count; i++)
                    {

                        total += Convert.ToDecimal(gv.Rows[i].Cells[4].Value);
                        if (Convert.ToInt32(gv.Rows[i].Cells[0].Value) == Convert.ToInt32(cmbMedicine.SelectedValue))
                        {
                            if (Convert.ToDecimal(gv.Rows[i].Cells[2].Value) + Convert.ToDecimal(txtQty.Text) > Convert.ToInt32(lblAvailableStock.Text))
                            {
                                MessageBox.Show("Inputted stock is more then available Stock", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                flag2 = true;
                            }
                            else
                            {
                                gv.Rows[i].Cells[2].Value = Convert.ToDecimal(gv.Rows[i].Cells[2].Value) + Convert.ToDecimal(txtQty.Text);
                                gv.Rows[i].Cells[4].Value = (Convert.ToDecimal(gv.Rows[i].Cells[2].Value) * Convert.ToDecimal(gv.Rows[i].Cells[3].Value));
                                flag = true;
                            }


                        }

                    }
                    if (!flag2)
                    {
                        total += (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text));
                        lblTotal.Text = total.ToString();
                    }
                    if (!flag && !flag2)
                    {
                        DateTime expiry = (from DataRow dr in dt.Rows
                                           where (int)dr["productID"] == (int)cmbMedicine.SelectedValue
                                           select (DateTime)dr["expiry"]).FirstOrDefault();
                        gv.Rows.Add(cmbMedicine.SelectedValue, cmbMedicine.Text, txtQty.Text, txtPrice.Text, (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)), expiry);
                    }
                    txtQty.Text = "";
                    txtPrice.Text = "";
                    cmbMedicine.SelectedIndex = -1;
                    lblAvailableStock.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("All Fields are Required");
            }
        }

        private void getMedicine()
        {
            res = db.getMedicine();
            dt = ((DataSet)res.data).Tables[0];
            if (res.success)
            {
                DataSet ds = new DataSet();
                ds = res.data;
                cmbMedicine.DataSource = ds.Tables[0];
                cmbMedicine.DisplayMember = "productName";
                cmbMedicine.ValueMember = "productID";
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMedicine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cmbMedicine.SelectedIndex;

            decimal price = (from DataRow dr in dt.Rows
                             where (int)dr["productID"] == (int)cmbMedicine.SelectedValue
                             select (decimal)dr["salesPrice"]).FirstOrDefault();
            int availableStock = (from DataRow dr in dt.Rows
                                  where (int)dr["productID"] == (int)cmbMedicine.SelectedValue
                                  select (int)dr["qty"]).FirstOrDefault();
            txtPrice.Text = price.ToString();
            lblAvailableStock.Text = availableStock.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.customerID = 0;
            invoice.customerName = txtCustomer.Text;
            invoice.qtyCount = gv.Rows.Count;
            invoice.amount = Convert.ToDecimal(lblTotal.Text);
            List<InvoiceItems> ItemsList = new List<InvoiceItems>();
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                InvoiceItems item = new InvoiceItems();
                item.productID = Convert.ToInt32(gv.Rows[i].Cells[0].Value);
                item.qty = Convert.ToInt32(gv.Rows[i].Cells[2].Value);
                item.price = Convert.ToInt32(gv.Rows[i].Cells[3].Value);
                item.expiry = Convert.ToDateTime(gv.Rows[i].Cells[5].Value);
                //InvoiceItems item = new InvoiceItems()
                //{
                //    productID = Convert.ToInt32(gv.Rows[i].Cells[0].Value),
                //    qty = Convert.ToInt32(gv.Rows[i].Cells[2].Value),
                //    price = Convert.ToInt32(gv.Rows[i].Cells[3].Value),
                //    expiry = Convert.ToDateTime(gv.Rows[i].Cells[5].Value),
                //};
                //invoice.items.Add(new InvoiceItems()
                //{
                //    productID = Convert.ToInt32(gv.Rows[i].Cells[0].Value),
                //    qty = Convert.ToInt32(gv.Rows[i].Cells[2].Value),
                //    price = Convert.ToDecimal(gv.Rows[i].Cells[3].Value),
                //    expiry = Convert.ToDateTime(gv.Rows[i].Cells[5].Value)
                //});
                ItemsList.Add(item);
                
            }
            invoice.items = ItemsList;
            res = db.addInvoice(invoice);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gv.Rows.Clear();
                lblTotal.Text = "0";
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message + " on step number : " + res.data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            lblTotal.Text = (Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(e.Row.Cells[4].Value)).ToString();
        }
    }
}
