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
    public partial class Activation : Form
    {
        static connection cn = new connection();
        public Activation()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            //txtKey.Text
            DateTime trial = DateTime.Now;
            if (!Properties.Settings.Default.Checked)
            {
                Properties.Settings.Default.trial = trial;
                Properties.Settings.Default.Checked = true;
                MessageBox.Show("Demo Started ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Save();
            }
            else
            {
                if (Properties.Settings.Default.trial.AddDays(30) > DateTime.Now)
                {
                    MessageBox.Show("Demo Started...");
                    MetroSetForm main = new Login();
                    main.Show();
                    //Form act = new Activation();
                    //act.Close();
                    this.Hide();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Demo Expired.", "Contact US: For Full Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            DateTime validity = DateTime.Now;
            string Key = cn.Encrypt("KP" + DateTime.Now.Year);

            if (Key == txtKey.Text)
            {
                Properties.Settings.Default.Registered = true;
                Properties.Settings.Default.Validity = validity;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.Validity.Add(new TimeSpan(360, 0, 0, 0, 0)) > DateTime.Now)
                {
                    MetroSetForm main = new Login();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Re - active your software. (Contact To Developer)");
                }
            }
            else
            {
                Properties.Settings.Default.Registered = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Invalid Key", "Activation Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //txtKey.Text = Key;
        }

        private void Activation_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.ExitThread();
        }

        private void Activation_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Validity.Add(new TimeSpan(360, 0, 0, 0, 0)) > DateTime.Now)
            {

                MetroSetForm main = new Login();
                main.Show();
                try
                {
                    this.Hide();
                }
                catch (Exception ex) {

                }
            }
            else
            {
                Properties.Settings.Default.Registered = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
