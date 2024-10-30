using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
	public class HangGiay
	{
		public string TenHang { get; set; }  // varchar(150)
		public string IdNCC { get; set; }  // varchar(50)

		public HangGiay() { }

		public HangGiay(string tenHang, string idNCC)
		{
			TenHang = tenHang;
			IdNCC = idNCC;
		}
	}

}
