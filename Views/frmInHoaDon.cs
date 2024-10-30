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
	public partial class frmInHoaDon : Form
	{
		
		public frmInHoaDon(User user)
		{
			InitializeComponent();
		
			lblNgayNhap.Text = (DateTime.Now).ToString("dd/MM/yyyy");
		}
		private void frmInHoaDon_Load(object sender, EventArgs e)
		{
			LoadCBTenGiay(sender, e);
			LoadListView();
			
		}
		private void LoadCBTenGiay(object sender, EventArgs e)
		{
			
			
		}
		public void LoadListView()
		{
			

			
		}
		private void cbTenGiay_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void lv_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		private void btnLayidKhachHang_Click(object sender, EventArgs e)
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
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			
		}
		

		private void cbTenGiay_SelectionChangeCommitted(object sender, EventArgs e)
		{
			
		}


		private void btnXoaChiTietHD_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			frmDangNhap form = new frmDangNhap();
			form.Show();
			this.Hide();
		}

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxThongTinChiTiet_Enter(object sender, EventArgs e)
        {

        }
    }
}
