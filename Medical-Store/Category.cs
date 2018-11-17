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
    public partial class Category : MetroSetForm
    {
        Response res = new Response();
        controller db = new controller();
        public Category(int index)
        {
            InitializeComponent();
            CategoryTab.SelectedIndex = index;

            if (index == 1)
            {
                getCategory();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Category cat = new Shared.Category();
            cat.catName = txtName.Text;
            cat.catDesc = txtDescription.Text;
            res = db.AddCategory(cat);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show(res.message + "", "", MessageBoxButtons.OK);
        }

        private void CategoryTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryTab.SelectedIndex == 1)
            {
                chkEdit.Checked = false;
                getCategory();
            }
            // MessageBox.Show(CategoryTab.SelectedIndex + "","",MessageBoxButtons.OK);
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

        private void gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == gv.NewRowIndex || e.RowIndex < 0)
                return;

            Shared.Category category = new Shared.Category();
            category.ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells["ID"].Value);
            category.catName = Convert.ToString(gv.Rows[e.RowIndex].Cells["catName"].Value);
            category.catDesc = Convert.ToString(gv.Rows[e.RowIndex].Cells["catDesc"].Value);
            res = db.UpdateCategory(category);
            if (res.success)
            {
                MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getCategory();
            }
            else
            {
                MetroSetMessageBox.Show(this, res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    res = db.DeleteCategory(gv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    if (res.success)
                    {
                        MetroSetMessageBox.Show(this, res.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getCategory();
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
