using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmDangNhap : Form
    {
        User user = new User();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.Username = txtUser.Text.Trim();
            user.Password = txtPass.Text.Trim();
           
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(sender, e);
                }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
