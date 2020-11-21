using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class Bao
	{
		private int soTrang;
		private string nhaXuatBan;
		public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }

		public int SoTrang { get => soTrang; set => soTrang = value; }

		public Bao() { }
		public Bao(string nxb,int st)
		{
			NhaXuatBan = nxb;
			SoTrang = st;
		}
		//public Bao(string line)
		//{
		//	string[] str = line.Split(',');
		//	NhaXuatBan = str[0];
		//	SoTrang = int.Parse(str[1]);
		//}
		public void Nhap()
		{
			do
			{
				Console.Write("Nhap nha xuat ban: ");
				NhaXuatBan = Console.ReadLine();
				Console.Write("Nhap so trang: ");
				SoTrang = int.Parse(Console.ReadLine());
			} while (NhaXuatBan==null);
		}
		public override string ToString()
		{
			return string.Format("{0,-5} {1,-5}", NhaXuatBan, SoTrang);
		}
	}
}
