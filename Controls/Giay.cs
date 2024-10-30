using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
	public class Giay
	{
		public string Id { get; set; }  // varchar(50)
		public string TenGiay { get; set; }  // nvarchar(max)
		public int IdLoai { get; set; }  // int
		public int SoLuong { get; set; }  // int
		public int GiaNhap { get; set; }  // int
		public int GiaBan { get; set; }  // int
		public string Anh { get; set; }  // ntext
		public int IdHang { get; set; }  // int

		public Giay() { }

		public Giay(string id, string tenGiay, int idLoai, int soLuong, int giaNhap, int giaBan, string anh, int idHang)
		{
			Id = id;
			TenGiay = tenGiay;
			IdLoai = idLoai;
			SoLuong = soLuong;
			GiaNhap = giaNhap;
			GiaBan = giaBan;
			Anh = anh;
			IdHang = idHang;
		}
	}

}
