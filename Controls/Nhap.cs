using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
	public class Nhap
	{
		public string Id { get; set; }  // varchar(50)
		public string IdNV { get; set; }  // varchar(10)
		public DateTime NgayNhap { get; set; }  // date
		public int IdNCC { get; set; }  // int
		public int SoLuong { get; set; }  // int
		public int TongTien { get; set; }  // int
		public int Stt { get; set; }  // int

		public Nhap() { }

		public Nhap(string id, string idNV, DateTime ngayNhap, int idNCC, int soLuong, int tongTien, int stt)
		{
			Id = id;
			IdNV = idNV;
			NgayNhap = ngayNhap;
			IdNCC = idNCC;
			SoLuong = soLuong;
			TongTien = tongTien;
			Stt = stt;
		}
	}

}
