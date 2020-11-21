using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class TapChi
	{
		private string tuaDe;
		private int soTrang;
		private string nhaXuatBan;
		private int soBaiViet;

		public int SoBaiViet { get => soBaiViet; set => soBaiViet = value; }
		public string TuaDe { get => tuaDe; set => tuaDe = value; }
		public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
		public int SoTrang { get => soTrang; set => soTrang = value; }

		public TapChi() { }
		public TapChi(string td,string nxb,int sbv,int st)
		{
			TuaDe = td;
			SoTrang = st;
			NhaXuatBan = nxb;
			SoBaiViet = sbv;
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
				Console.Write("Nhap so bai viet: ");
				SoBaiViet = int.Parse(Console.ReadLine());
			} while (TuaDe==null);
		}
		public override string ToString()
		{
			return string.Format("{0,5} {1,-5} {2,-5} {3,-5}", TuaDe, SoTrang, NhaXuatBan, SoBaiViet);
		}
	}
}
