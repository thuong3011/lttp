using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmNhanVien : Form
    {
        Status status = new Status();
        NhanVien nhanvien = new NhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadListView();
            cbPhanQuyen.SelectedIndex = 1;
        }
        public void LoadListView()
        {
            
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
          
        }
        public static bool IsPhoneNumber(string number)
        {
            try
            {
                int sdt = int.Parse(number);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {

            txtTen.Text = "";
            txtUsername.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtRePass.Text = "";
        }
    }
}
