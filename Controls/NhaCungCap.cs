using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
	public class NhaCungCap
	{
		public int Id { get; set; }  // int
		public string Ten { get; set; }  // nvarchar(150)
		public string SDT { get; set; }  // varchar(10)
		public string Email { get; set; }  // varchar(100)
		public string DiaChi { get; set; }  // nvarchar(300)

		public NhaCungCap() { }

		public NhaCungCap(int id, string ten, string sdt, string email, string diaChi)
		{
			Id = id;
			Ten = ten;
			SDT = sdt;
			Email = email;
			DiaChi = diaChi;
		}
	}

}
