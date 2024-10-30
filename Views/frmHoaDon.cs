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
    public partial class frmHoaDon : Form
    {
        Status status = new Status();
        HoaDon hoaDon = new HoaDon();
        NhanVien nhanVien = new NhanVien();
        KhachHang khachHang = new KhachHang();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        public void LoadListView()
        {
          

        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxThongTinBoPhan_Enter(object sender, EventArgs e)
        {

        }
    }
}
