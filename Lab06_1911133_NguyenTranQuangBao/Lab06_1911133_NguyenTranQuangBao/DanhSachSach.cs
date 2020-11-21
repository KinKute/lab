using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class DanhSachSach
	{
		List<Sach> DSSach = new List<Sach>();
		public Sach this[int i]
		{
			get { return DSSach[i]; }
		}
		public void Them(Sach s)
		{
			DSSach.Add(s);
		}
		public override string ToString()
		{
			string line = "";
			foreach (var item in DSSach) { line += item + "\n"; }
			return line;
		}
		public void Xuat()
		{
			Console.WriteLine(this);
		}
	}
}
