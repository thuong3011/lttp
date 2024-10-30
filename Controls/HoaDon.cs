using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
	public class HoaDon
	{
		public string Id { get; set; }  // varchar(50)
		public string IdNV { get; set; }  // varchar(10)
		public string IdKH { get; set; }  // varchar(50)
		public DateTime NgayBan { get; set; }  // date
		public int SoLuong { get; set; }  // int
		public int TongTien { get; set; }  // int
		public int Stt { get; set; }  // Add this property if "stt" is defined in your table as int or another data type

		public HoaDon() { }

		public HoaDon(string id, string idNV, string idKH, DateTime ngayBan, int soLuong, int tongTien, int stt)
		{
			Id = id;
			IdNV = idNV;
			IdKH = idKH;
			NgayBan = ngayBan;
			SoLuong = soLuong;
			TongTien = tongTien;
			Stt = stt;
		}
	}

}
