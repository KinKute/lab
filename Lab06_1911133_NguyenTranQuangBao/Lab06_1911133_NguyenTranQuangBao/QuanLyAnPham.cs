using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
namespace Lab06_1911133_NguyenTranQuangBao
{
	class QuanLyAnPham
	{
		public DanhSachBao DSBao = new DanhSachBao();
		public DanhSachSach DSSach = new DanhSachSach();
		public DanhSachTapChi DSTapChi = new DanhSachTapChi();

		public void NhapBangTay()
		{
			string line = "";
			do
			{
				Console.Write("Moi nhap thong tin sach (tua de, nha xuat ban, so trang),bao (nha xuat ban, so trang), tap chi (tua de, nha xuat ban, so bai, so trang): ");
			a:
				line = Console.ReadLine();
				string[] str = line.Split(',');
				if (str[0] == "bao")
					DSBao.Them(new Bao(str[1], int.Parse(str[2])));
				else if (str[0] == "sach")
					DSSach.Them(new Sach(str[1], str[2], int.Parse(str[3])));
				else if (str[0] == "tap chi")
					DSTapChi.Them(new TapChi(str[1], str[2], int.Parse(str[3]), int.Parse(str[4])));
				else return;
				Console.Write("Moi nhap thong tin hoac thoat bang cach an phim bat ky! ");
				goto a;
			} while (line==null);
		}
		public void Xuat()
		{
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine("DANH SACH SACH \n" + "Tua de ".PadRight(15) + "Nha xuat ban ".PadRight(15) + "So trang ".PadRight(10));
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine(DSSach);
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine("DANH SACH TAP CHI \n" + "Tua de ".PadRight(15) + "Nha xuat ban".PadRight(15) + "So bai ".PadRight(15) + "So trang ".PadRight(15));
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine(DSTapChi);
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine("DANH SACH BAO \n" + "Nha xuat ban ".PadRight(15) + "So trang ".PadRight(10));
			Console.WriteLine("".PadRight(30), '=');
			Console.WriteLine(DSBao);
		}
		public void NhapTuFile()
		{
			string filename = "data.txt";
			StreamReader sr = new StreamReader(filename);
			string line = "";
			while ((line= sr.ReadLine())!=null)
			{
				string[] str = line.Split(',');
				if (str[0] == "Bao")
				{
					DSBao.Them(new Bao(str[1], int.Parse(str[2])));
					continue;
				}
				if (str[0] == "Tap chi")
				{
					DSTapChi.Them(new TapChi(str[1], str[2], int.Parse(str[3]), int.Parse(str[4])));
					continue;
				}
				if (str[0] == "Sach")
				{
					DSSach.Them(new Sach(str[1], str[2], int.Parse(str[3])));
					continue;
				}
			}
		}
	}
}
