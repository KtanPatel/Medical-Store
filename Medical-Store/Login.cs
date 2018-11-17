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
    public partial class Login : MetroSetForm
    {
        controller controller = new controller();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.userName = txtUname.Text;
            user.password = txtPass.Text;
            // MessageBox.Show(controller.Login(user)+ "","msg",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            if (controller.Login(user) == 1)
            {
                MetroSetForm home = new Dashboard();
                home.Show();
                this.Hide();
            }
            else
            {
                MetroSetMessageBox.Show(this, "Invalid Username or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
