using System;
using System.Numerics;
namespace Btap
{
    public class PhanSo
    {
        int Tu, Mau;
        public void NhapPhanSo()
        {
            Console.WriteLine("Nhap tu so: ");
            Tu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            Mau = Convert.ToInt32(Console.ReadLine());
            if (Mau == 0)
            {
                Console.WriteLine("Mau so phai khac 0. Vui long nhap lai!");
                Mau = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void GanGiaTri(int TuSo, int MauSo)
        {
            Tu = TuSo;
            Mau = MauSo;
        }
        public void XuatPhanSo()
        {
            Console.WriteLine("Phan so : {0}/{1}", Tu, Mau);
        }
        public PhanSo Cong(PhanSo PS2)
        {
            PhanSo KetQua = new PhanSo();
            KetQua.Tu = Tu * PS2.Mau + Mau * PS2.Tu;
            KetQua.Mau = Mau * PS2.Mau;
            return KetQua;
        }
        public PhanSo Tru(PhanSo PS2)
        {
            PhanSo KetQua = new PhanSo();
            KetQua.Tu = Tu * PS2.Mau - Mau * PS2.Tu;
            KetQua.Mau = Mau * PS2.Mau;
            return KetQua;
        }
        public PhanSo Nhan(PhanSo PS2)
        {
            PhanSo KetQua = new PhanSo();
            KetQua.Tu = Tu * PS2.Tu;
            KetQua.Mau = Mau * PS2.Mau;
            return KetQua;
        }
        public PhanSo Chia(PhanSo PS2)
        {
            PhanSo KetQua = new PhanSo();
            KetQua.Tu = Tu * PS2.Mau;
            KetQua.Mau = Mau * PS2.Tu;
            return KetQua;
        }
        public PhanSo RutRon()
        {
            int gcd = GCD(Tu, Mau);
            Tu /= gcd;
            Mau /= gcd;
            return this;
        }
        private int GCD(int a, int b)
        {
            return (int)BigInteger.GreatestCommonDivisor(Math.Abs(a), Math.Abs(b));
        }
        public PhanSo CongSoNguyen(int n)
        {
            PhanSo KetQua = new PhanSo();
            KetQua.Tu = Tu + n * Mau;
            KetQua.Mau = Mau;
            return KetQua;
        }
    }
    public class Bai2_9
    {
        public void Run()
        {

            PhanSo PS1 = new PhanSo();
            PhanSo PS2 = new PhanSo();
            Console.WriteLine("Nhap phan so thu nhat");
            PS1.NhapPhanSo();
            Console.WriteLine("Nhap phan so thu hai");
            PS2.NhapPhanSo();
            Console.WriteLine("Phan so thu nhat: ");
            PS1.XuatPhanSo();
            Console.WriteLine("Phan so thu hai: ");
            PS2.XuatPhanSo();

            PhanSo Tong = PS1.Cong(PS2);
            Console.Write("Tong hai phan so: ");
            Tong.XuatPhanSo();

            PhanSo Hieu = PS1.Tru(PS2);
            Console.Write("Hieu hai phan so: ");
            Hieu.XuatPhanSo();

            PhanSo Tich = PS1.Nhan(PS2);
            Console.Write("Tich hai phan so: ");
            Tich.XuatPhanSo();

            PhanSo Thuong = PS1.Chia(PS2);
            Console.Write("Thuong hai phan so: ");
            Thuong.XuatPhanSo();
            
            Console.WriteLine("Rut gon phan so thu nhat: ");
            PS1.RutRon();
            PS1.XuatPhanSo();
            Console.WriteLine("Rut gon phan so thu hai: ");
            PS2.RutRon();
            PS2.XuatPhanSo();

            Console.WriteLine("Nhap so nguyen muon cong:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chon phan so de cong voi so nguyen: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PhanSo KetQua1 = PS1.CongSoNguyen(n);
                    Console.WriteLine("Ket qua cong phan so thu nhat voi so nguyen {0}: ", n);
                    KetQua1.XuatPhanSo();
                    break;
                case 2:
                    PhanSo KetQua2 = PS2.CongSoNguyen(n);
                    Console.WriteLine("Ket qua cong phan so thu hai voi so nguyen {0}: ", n);
                    KetQua2.XuatPhanSo();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}