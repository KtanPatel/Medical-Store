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
    public partial class Company : MetroSetForm
    {
        Response res = new Response();
        controller db = new controller();
        public Company(int index)
        {
            InitializeComponent();
            CompanyTab.SelectedIndex = index;

            if (index == 1)
            {
                getCompany();

            }
        }

        private void getCompany()
        {
            res = db.GetCompany();
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
            // MessageBox.Show(res.message + "", "", MessageBoxButtons.OK);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Company com = new Shared.Company();
            com.companyName = txtName.Text;
            com.address = txtAddress.Text;
            com.contact = txtContact.Text;
            res = db.AddCompany(com);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    res = db.DeleteCompany(gv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
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

        private void gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == gv.NewRowIndex || e.RowIndex < 0)
                return;

            Shared.Company company = new Shared.Company();
            company.ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells["ID"].Value);
            company.companyName = Convert.ToString(gv.Rows[e.RowIndex].Cells["companyName"].Value);
            company.address = Convert.ToString(gv.Rows[e.RowIndex].Cells["address"].Value);
            company.contact = Convert.ToString(gv.Rows[e.RowIndex].Cells["contact"].Value);
            res = db.UpdateCompany(company);
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

        private void CompanyTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyTab.SelectedIndex == 1)
            {
                chkEdit.Checked = false;
                getCompany();
            }
        }
    }
}
