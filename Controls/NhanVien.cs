using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
	public class NhanVien
	{
		public string Id { get; set; }  // varchar(10)
		public string TenNV { get; set; }  // nvarchar(100)
		public string Username { get; set; }  // nchar(20)
		public string Password { get; set; }  // nchar(20)
		public string SDT { get; set; }  // varchar(10)
		public string Email { get; set; }  // varchar(100)
		public string DiaChi { get; set; }  // nvarchar(200)
		public int PhanQuyen { get; set; }  // int
		public int Stt { get; set; }  // int

		public NhanVien() { }

		public NhanVien(string id, string tenNV, string username, string password, string sdt, string email, string diaChi, int phanQuyen, int stt)
		{
			Id = id;
			TenNV = tenNV;
			Username = username;
			Password = password;
			SDT = sdt;
			Email = email;
			DiaChi = diaChi;
			PhanQuyen = phanQuyen;
			Stt = stt;
		}
	}

}
