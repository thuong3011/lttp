using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
	public class KhachHang
	{
		public string Id { get; set; }  // varchar(50)
		public string TenKH { get; set; }  // nvarchar(100)
		public string SDT { get; set; }  // varchar(10)
		public string Email { get; set; }  // varchar(100)
		public string DiaChi { get; set; }  // nvarchar(200)
		public int TongTien { get; set; }  // int

		public KhachHang() { }

		public KhachHang(string id, string tenKH, string sdt, string email, string diaChi, int tongTien)
		{
			Id = id;
			TenKH = tenKH;
			SDT = sdt;
			Email = email;
			DiaChi = diaChi;
			TongTien = tongTien;
		}
	}

}
