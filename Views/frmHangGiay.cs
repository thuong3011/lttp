using System;
using System.Data;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
	public partial class frmHangGiay : Form
	{
		Status status = new Status();
		HangGiay hangiay = new HangGiay();

		public frmHangGiay()
		{
			InitializeComponent();
		}

		private void frmHangGiay_Load(object sender, EventArgs e)
		{
			LoadListView();
			btnThem.Enabled = true;
			btnCapNhat.Enabled = false;
			btnXoa.Enabled = false;
		}

		public void LoadListView()
		{
			

			
		}

		private void btnTimKiemTen_Click(object sender, EventArgs e)
		{
			
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			
		}

		private void lv_SelectedIndexChanged(object sender, EventArgs e)
		{
			
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

			// Thiết lập trạng thái nút trở về ban đầu
			btnThem.Enabled = true;
			btnCapNhat.Enabled = false;
			btnXoa.Enabled = false;
		}

		private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnTimKiemTen_Click(sender, e);
			}
		}
		private void groupBoxThongTinChiTiet_Enter(object sender, EventArgs e)
		{
			// Thực hiện các hành động khi sự kiện Enter xảy ra cho groupBoxThongTinChiTiet, nếu cần.
		}

        private void groupBoxThongTinBoPhan_Enter(object sender, EventArgs e)
        {

        }
    }
}
