using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class DanhSachBao
	{
		List<Bao> DSBao = new List<Bao>();
		public Bao this[int i]
		{
			get { return DSBao[i]; }
		}
		public void Them(Bao b)
		{
			DSBao.Add(b);
		}
		public override string ToString()
		{
			string line = "";
			foreach(var item in DSBao)
			{ line += item + "\n"; }
			return line;
		}
		public void Xuat()
		{
			Console.WriteLine(this); 
		}
	}
}
