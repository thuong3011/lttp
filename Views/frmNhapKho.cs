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
    public partial class frmNhapKho : Form
    {
        Status status = new Status();
      
        User user;
        public frmNhapKho(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadListView()
        {
           
            
        }
        private void LoadCBNhaCungCap()
        {
            
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
