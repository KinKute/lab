using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class DanhSachTapChi
	{
		List<TapChi> DSTapChi = new List<TapChi>();
		public TapChi this[int i]
		{
			get { return DSTapChi[i]; }
		}
		public void Them(TapChi tc)
		{
			DSTapChi.Add(tc);
		}
		public override string ToString()
		{
			string line = "";
			foreach (var item in DSTapChi) { line += item + "\n"; }
			return line;
		}
		public void Xuat()
		{
			Console.WriteLine(this);
		}
	}
}
