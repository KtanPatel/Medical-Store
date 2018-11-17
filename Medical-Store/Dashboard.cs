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
// using MetroSet_UI;

namespace Medical_Store
{
    public partial class Dashboard : MetroSetForm
    {
        //StyleManager styleManager1 = new StyleManager();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MetroSetForm login = new Login();
            login.Show();
        }

        private void metroSetSwitch1_SwitchedChanged(object sender)
        {
            //if (styleManager1.Style == MetroSet_UI.Design.Style.Light)
            //{
            //    styleManager1.Style = MetroSet_UI.Design.Style.Dark;
            //}
            //else
            //{
            //    styleManager1.Style = MetroSet_UI.Design.Style.Light;
            //}

            //this.Style = MetroSet_UI.Design.Style.Dark;
        }
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception)
            {

            }

        }
        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addCompany = new Company(0);
            addCompany.MdiParent = this;
            addCompany.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addCompany = new Company(1);
            addCompany.MdiParent = this;
            addCompany.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addCat = new Category(0);
            addCat.MdiParent = this;
            addCat.Show();
        }

        private void medicineCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addCat = new Category(1);
            addCat.MdiParent = this;
            addCat.Show();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addMedicine = new Medicine(0);
            addMedicine.MdiParent = this;
            addMedicine.Show();
        }

        private void medicineListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm addMedicine = new Medicine(1);
            addMedicine.MdiParent = this;
            addMedicine.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            //p.WaitForInputIdle();
            //NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
            System.Diagnostics.Process.Start("calc");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr");
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm invoice = new Sales();
            invoice.MdiParent = this;
            invoice.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm stockEntry = new Purchase(0);
            stockEntry.MdiParent = this;
            stockEntry.Show();
        }
        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm stockEntry = new Purchase(1);
            stockEntry.MdiParent = this;
            stockEntry.Show();
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
        }

        private void expireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm alert = new Alert(0);
            alert.MdiParent = this;
            alert.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            MetroSetForm alert = new Alert(1);
            alert.MdiParent = this;
            alert.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox();
            about.Show();
        }
    }
}
