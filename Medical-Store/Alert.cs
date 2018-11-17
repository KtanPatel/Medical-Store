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
    public partial class Alert : MetroSetForm
    {
        Response res = new Response();
        stockController db = new stockController();
        public Alert(int index)
        {

            InitializeComponent();
            AlertTab.SelectedIndex = index;

            if (index == 0)
                getExStock(45);
            else
                getSTStock(10);

        }

        private void getExStock(int days) {
            res = db.getExpireStock(days);
            if (res.success)
            {
                DataSet ds = res.data;
                gvExpire.Columns.Clear();
                gvExpire.DataSource = ds.Tables[0];
                // gv.EditMode = DataGridViewEditMode.EditOnF2;
                gvExpire.ReadOnly = true;
                // gv.Columns[1].Visible = false;
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                // deleteButton.DisplayIndex = 0;
                deleteButton.Name = "gvReturnButton";
                deleteButton.HeaderText = "Return";
                deleteButton.Text = "Return";
                deleteButton.UseColumnTextForButtonValue = true;
                // Deletelink.Text = "DEL";
                gvExpire.Columns.Add(deleteButton);
                gvExpire.AllowUserToDeleteRows = false;
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getSTStock(int count)
        {
            res = db.getShortageStock(count);
            if (res.success)
            {
                DataSet ds = res.data;
                gvStock.Columns.Clear();
                gvStock.DataSource = ds.Tables[0];
                // gv.EditMode = DataGridViewEditMode.EditOnF2;
                gvStock.ReadOnly = true;
                gvStock.AllowUserToDeleteRows = false;
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            getExStock(Convert.ToInt32(txtDays.Text));
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            getSTStock(Convert.ToInt32(txtCount.Text));
        }

        private void AlertTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlertTab.SelectedIndex == 1)
            {   
                getSTStock(10);
                txtCount.Text = "10";
            }
            else {
                getExStock(45);
                txtDays.Text = "45";
            }
        }

        private void gvExpire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gvExpire.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == gvExpire.Columns["gvReturnButton"].Index)
            {
                // Put some logic here, for example to remove row from your binding list.
                // yourBindingList.RemoveAt(e.RowIndex);
                DialogResult dr = MessageBox.Show("Are you sure to want Return this Product ?", "Return Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // res = db.DeleteCategory(gvExpire.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    res = db.returnStock(gvExpire.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    if (res.success)
                    {
                        MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getExStock(Convert.ToInt32(txtDays.Text));
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
