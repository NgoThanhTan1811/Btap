using System;
using System.Collections.Generic;

namespace Btap
{
    public class HCN
    {
        public int x1, y1, x2, y2;
        public HCN(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public int KiemTra()
        {
            try
            {
                if (x2 > x1 && y1 > y2)
                {
                    Console.WriteLine("Hinh chu nhat hop le");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Hinh chu nhat khong hop le");
                    return 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Loi: Toa do khong hop le");
                return -1;
            }
        }
        public int ChieuRong()
        {
            return Math.Abs(y2 - y1);
        }
        public int ChieuDai()
        {
            return Math.Abs(x2 - x1);
        }

        public int ChuVi()
        {
            return (ChieuDai() + ChieuRong()) * 2;
        }

        public int DienTich()
        {
            return ChieuRong() * ChieuDai();
        }
        public class Bai1_8
        {
            public void Run()
            {
                HCN hcn;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Nhap toa do diem thu nhat (x1,y1): ");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Nhap toa do diem thu hai (x2,y2): ");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());

                        hcn = new HCN(x1, y1, x2, y2);

                        if (hcn.KiemTra() == 1)
                            break; // nhập đúng thì thoát vòng lặp
                        else
                            Console.WriteLine("Nhập lại!\n");
                    }
                    catch
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại!\n");
                    }
                }

                Console.WriteLine("Chiều dài: " + hcn.ChieuDai());
                Console.WriteLine("Chiều rộng: " + hcn.ChieuRong());
                Console.WriteLine("Chu vi: " + hcn.ChuVi());
                Console.WriteLine("Diện tích: " + hcn.DienTich());
            }


        }
    }
}

        