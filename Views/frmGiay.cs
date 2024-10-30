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
    public partial class frmGiay : Form
    {
        Status status = new Status();
        Giay giay;
        string idLoaiGiay = "0";
        public frmGiay()
        {
            InitializeComponent();
        }
        public frmGiay(string idLoaiGiay)
        {
            InitializeComponent();
            this.idLoaiGiay = idLoaiGiay;
        }
        private void frmGiay_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadListView()
        {
           

        }
        private void LoadCBTenGiay()
        {
          
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
           
        }
        public static bool IsPositiveNumber(string number)
        {
            if (IsNumber(number) == false)
            {
                return false;
            }

            int num = int.Parse(number);
            if(num > 0)
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
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiemTen_Click(sender, e);
            }
        }

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void ncc_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
