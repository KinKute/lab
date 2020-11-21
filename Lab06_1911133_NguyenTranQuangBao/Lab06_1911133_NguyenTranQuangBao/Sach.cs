using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class Sach
	{
		private string tuaDe;
		private int soTrang;
		private string nhaXuatBan;

		public int SoTrang { get => soTrang; set => soTrang = value; }
		public string TuaDe { get => tuaDe; set => tuaDe = value; }
		public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }

		public Sach() { }
		public Sach(string T,string nxb,int tr)
		{
			TuaDe = T;
			NhaXuatBan = nxb;
			SoTrang = tr;
		}

		public void Nhap()
		{
			do
			{
				Console.Write("Nhap tua de: ");
				TuaDe = Console.ReadLine();
				Console.Write("Nhap so trang: ");
				SoTrang = int.Parse(Console.ReadLine());
				Console.Write("Nhap nha xuat ban: ");
				NhaXuatBan = Console.ReadLine();
			} while (TuaDe == null);
		}
		public override string ToString()
		{
			return string.Format("{0,5} {1,15} {2,15)",TuaDe,NhaXuatBan,SoTrang);	
		}
	}	
}
