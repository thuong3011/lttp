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
    public partial class frmKhachHang : Form
    {
        Status status = new Status();
        KhachHang khachhang = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadListView();
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            
        }
    }
}
