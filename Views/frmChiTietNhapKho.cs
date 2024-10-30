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
    public partial class frmChiTietNhapKho : Form
    {
       
        public frmChiTietNhapKho(string idNhapKho)
        {
            InitializeComponent();
       
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmChiTietNhapKho_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadListView()
        {
           

          
        }
        private void LoadCBTenGiay()
        {
           
        }

        private void btnThemChiTietNhapKho_Click(object sender, EventArgs e)
        {
            
        }
        public static bool IsPositiveNumber(string number)
        {
            if (IsNumber(number) == false)
            {
                return false;
            }

            int num = int.Parse(number);
            if (num > 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsNumber(string number)
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
        private void btnThemChiTietNhapKho_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBoxThongTinChiTiet_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
