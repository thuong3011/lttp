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
	public partial class frmDanhMuc : Form
	{
		Status status = new Status();
		DanhMuc danhmuc = new DanhMuc();

		public frmDanhMuc()
		{
			InitializeComponent();
		}

		private void frmDanhMuc_Load(object sender, EventArgs e)
		{
			

			LoadCBHangGiay();
			LoadListView();
		}

		public void LoadListView()
		{
		


		}

		private void LoadCBHangGiay()
		{
			
		}

		private void lv_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void btnTimKiemTen_Click(object sender, EventArgs e)
		{
			
		}

		private void btnSoanLai_Click(object sender, EventArgs e)
		{
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			
		}

		private void btnChiTiet_Click(object sender, EventArgs e)
		{
			
		}

		private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
		{
			
		}
	}
}
