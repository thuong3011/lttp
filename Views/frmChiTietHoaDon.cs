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
    public partial class frmChiTietHoaDon : Form
    {
        Status status = new Status();
       
        DanhMuc danhMuc = new DanhMuc();
        Giay giay = new Giay();

        string idHoaDon;
        public frmChiTietHoaDon(string idHoaDon)
        {
            InitializeComponent();
            this.idHoaDon = idHoaDon;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
           
            LoadListView();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
           
            DataRow[] foundRows;

        }

        private void groupBoxThongTinBoPhan_Enter(object sender, EventArgs e)
        {

        }
    }
}
