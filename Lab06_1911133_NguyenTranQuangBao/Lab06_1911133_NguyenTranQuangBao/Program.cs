using System;

namespace Lab06_1911133_NguyenTranQuangBao
{
	class Program
	{
		enum Menu
		{
			thoat,
			nhaptay,
			nhapfile
		}
		static void Main(string[] args)
		{
			QuanLyAnPham ql = new QuanLyAnPham();
		while (true)
			{
				Console.WriteLine("".PadRight(30, '=') + " HE THONG CHUC NANG " + "".PadRight(30, '='));
				Console.WriteLine("Nhap {0} de thoat",(int)Menu.thoat);
				Console.WriteLine("Nhap {0} de nhap bang tay",(int)Menu.nhaptay);
				Console.WriteLine("Nhap {0} de nhap tu file",(int)Menu.nhapfile);
				Menu nhap = (Menu)int.Parse(Console.ReadLine());
				switch(nhap)
				{
					case Menu.thoat:
						return;
					case Menu.nhaptay:
						{
							Console.Clear();
							Console.WriteLine("".PadRight(30), '=');
							Console.WriteLine("NHAP BANG TAY");
							Console.WriteLine("".PadRight(30), '=');
							ql.NhapBangTay();
							ql.Xuat();
						}break;
					case Menu.nhapfile:
						{
							Console.Clear();
							Console.WriteLine("".PadRight(30), '=');
							Console.WriteLine("".PadRight(30, '=') + " NHAP TU FILE " + "".PadRight(30, '='));
							Console.WriteLine("".PadRight(30), '=');
							ql.NhapTuFile();
							ql.Xuat();
						}break;
				}
			}
		}
	}
}
