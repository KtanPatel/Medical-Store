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
    public partial class Medicine : MetroSetForm
    {
        Response res = new Response();
        controller db = new controller();
        public Medicine(int index)
        {
            InitializeComponent();
            MedicineTab.SelectedIndex = index;
            if (index == 1)
            {
                getMedicine();

            }
            getCompany();
            getCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Product prod = new Shared.Product();
            prod.productName = txtName.Text;
            prod.productDescription = txtDesc.Text;
            prod.unit = cmbUnit.Text;
            prod.catID = Convert.ToInt32(cmbCategory.SelectedValue);
            prod.companyID = Convert.ToInt32(cmbCompany.SelectedValue);
            res = db.AddProduct(prod);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getMedicine()
        {
            res = db.GetProduct();
            if (res.success)
            {
                DataSet ds = res.data;
                gv.Columns.Clear();
                gv.DataSource = ds.Tables[0];
                // gv.EditMode = DataGridViewEditMode.EditOnF2;
                gv.ReadOnly = true;
                // gv.Columns[1].Visible = false;
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                // deleteButton.DisplayIndex = 0;
                deleteButton.Name = "gvDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                // Deletelink.Text = "DEL";
                gv.Columns.Add(deleteButton);
                gv.AllowUserToDeleteRows = false;
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getCompany()
        {
            res = db.GetCompany();
            if (res.success)
            {
                DataSet ds = new DataSet();
                ds = res.data;
                cmbCompany.DataSource = ds.Tables[0];
                cmbCompany.DisplayMember = "companyName";
                cmbCompany.ValueMember = "ID";
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getCategory()
        {
            res = db.GetCategory();
            if (res.success)
            {
                DataSet ds = new DataSet();
                ds = res.data;
                cmbCategory.DataSource = ds.Tables[0];
                cmbCategory.DisplayMember = "catName";
                cmbCategory.ValueMember = "ID";
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MedicineTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicineTab.SelectedIndex == 1)
            {
                chkEdit.Checked = false;
                getMedicine();
            }
        }

        private void chkEdit_CheckedChanged(object sender)
        {
            if (chkEdit.Checked)
            {
                gv.ReadOnly = false;
                // gv.AllowUserToDeleteRows = true;
            }
            else
                gv.ReadOnly = true;
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == gv.Columns["gvDeleteButton"].Index)
            {
                // Put some logic here, for example to remove row from your binding list.
                // yourBindingList.RemoveAt(e.RowIndex);
                DialogResult dr = MessageBox.Show("Are you sure to want delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    res = db.DeleteProduct(gv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    if (res.success)
                    {
                        MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getMedicine();
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == gv.NewRowIndex || e.RowIndex < 0)
                return;

            Shared.Product prod = new Shared.Product();
            prod.ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells["ID"].Value);
            prod.unit = Convert.ToString(gv.Rows[e.RowIndex].Cells["Unit"].Value);
            prod.productName = Convert.ToString(gv.Rows[e.RowIndex].Cells["Medicine"].Value);
            prod.productDescription = Convert.ToString(gv.Rows[e.RowIndex].Cells["Description"].Value);
            res = db.UpdateProduct(prod);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getCompany();
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
