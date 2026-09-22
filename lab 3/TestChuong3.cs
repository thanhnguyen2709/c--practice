/*
 * ============================================================
 * TEST CASE - CHƯƠNG 3: CẤU TRÚC RẼ NHÁNH
 * ============================================================
 * Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Cách chạy: dotnet run TestChuong3.cs
 * ============================================================
 */

using System;

namespace LTCsharp.Test
{
    class TestChuong3
    {
        static int pass = 0, total = 0;

        static void KiemTra(string tenTest, double ketQua, double mongDoi, double saiSo = 0.01)
        {
            total++;
            bool dung = (Math.Abs(ketQua - mongDoi) <= saiSo);
            if (dung) pass++;
            Console.WriteLine("  {0}: {1} (mong doi: {2}) => {3}",
                tenTest, ketQua, mongDoi, dung ? "PASS" : "FAIL");
        }

        static void KiemTra(string tenTest, string ketQua, string mongDoi)
        {
            total++;
            bool dung = (ketQua == mongDoi);
            if (dung) pass++;
            Console.WriteLine("  {0}: {1} (mong doi: {2}) => {3}",
                tenTest, ketQua, mongDoi, dung ? "PASS" : "FAIL");
        }

        // ===================================================================
        // TEST BÀI 1: TÌM MAX MIN 5 SỐ
        // ===================================================================
        static void TestMaxMin5So()
        {
            Console.WriteLine("--- Test Bai 1: Tim Max Min 5 so ---");

            // Test với số dương: (1, 5, 6, 2, 8)
            {
                double a=1, b=5, c=6, d=2, e=8;
                double max=a, min=a;
                if (b>max) max=b; if (c>max) max=c; if (d>max) max=d; if (e>max) max=e;
                if (b<min) min=b; if (c<min) min=c; if (d<min) min=d; if (e<min) min=e;
                KiemTra("Test 1.1: (1,5,6,2,8) => Max", max, 8);
                KiemTra("Test 1.2: (1,5,6,2,8) => Min", min, 1);
            }

            // Test với số âm: (-3, -1, -5, -2, -4)
            {
                double a=-3, b=-1, c=-5, d=-2, e=-4;
                double max=a, min=a;
                if (b>max) max=b; if (c>max) max=c; if (d>max) max=d; if (e>max) max=e;
                if (b<min) min=b; if (c<min) min=c; if (d<min) min=d; if (e<min) min=e;
                KiemTra("Test 1.3: (-3,-1,-5,-2,-4) => Max", max, -1);
                KiemTra("Test 1.4: (-3,-1,-5,-2,-4) => Min", min, -5);
            }

            // Test 5 số bằng nhau: (7, 7, 7, 7, 7)
            {
                double a=7, b=7, c=7, d=7, e=7;
                double max=a, min=a;
                if (b>max) max=b; if (c>max) max=c; if (d>max) max=d; if (e>max) max=e;
                if (b<min) min=b; if (c<min) min=c; if (d<min) min=d; if (e<min) min=e;
                KiemTra("Test 1.5: (7,7,7,7,7) => Max", max, 7);
                KiemTra("Test 1.6: (7,7,7,7,7) => Min", min, 7);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 2: TÍNH GIÁ TRỊ HÀM SỐ 1
        // f1(x): x<=0 → 0, 0<x<=1 → x, x>1 → x⁴
        // f2(x): x<=2 → x²+4x+5, x>2 → 1/(x²+4x+5)
        // ===================================================================
        static void TestGiaTriHamSo1()
        {
            Console.WriteLine("--- Test Bai 2: Tinh gia tri ham so 1 ---");

            // Hàm tính f1
            double TinhF1(double x)
            {
                if (x <= 0) return 0;
                else if (x <= 1) return x;
                else return x * x * x * x;
            }

            // Hàm tính f2
            double TinhF2(double x)
            {
                double bt = x * x + 4 * x + 5;
                return (x <= 2) ? bt : 1.0 / bt;
            }

            // x = -2: f1=0, f2=4-8+5=1
            KiemTra("Test 2.1: f1(-2)", TinhF1(-2), 0);
            KiemTra("Test 2.2: f2(-2)", TinhF2(-2), 1);

            // x = 0: f1=0 (x<=0), f2=0+0+5=5
            KiemTra("Test 2.3: f1(0)", TinhF1(0), 0);
            KiemTra("Test 2.4: f2(0)", TinhF2(0), 5);

            // x = 0.5: f1=0.5 (0<x<=1), f2=0.25+2+5=7.25
            KiemTra("Test 2.5: f1(0.5)", TinhF1(0.5), 0.5);
            KiemTra("Test 2.6: f2(0.5)", TinhF2(0.5), 7.25);

            // x = 1: f1=1 (0<x<=1), f2=1+4+5=10
            KiemTra("Test 2.7: f1(1)", TinhF1(1), 1);
            KiemTra("Test 2.8: f2(1)", TinhF2(1), 10);

            // x = 2: f1=16 (x>1 → x⁴), f2=4+8+5=17 (x<=2)
            KiemTra("Test 2.9: f1(2)", TinhF1(2), 16);
            KiemTra("Test 2.10: f2(2)", TinhF2(2), 17);

            // x = 3: f1=81, f2=1/(9+12+5)=1/26≈0.0385
            KiemTra("Test 2.11: f1(3)", TinhF1(3), 81);
            KiemTra("Test 2.12: f2(3)", TinhF2(3), 1.0 / 26);

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 3: GIẢI PHƯƠNG TRÌNH BẬC 2
        // ax² + bx + c = 0, Delta = b² - 4ac
        // ===================================================================
        static void TestPhuongTrinhBac2()
        {
            Console.WriteLine("--- Test Bai 3: Giai phuong trinh bac 2 ---");

            // PT: x² + 5x + 6 = 0 → Delta=1>0, x1=-2, x2=-3
            {
                double a=1, b=5, c=6;
                double delta = b*b - 4*a*c;
                double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2*a);
                KiemTra("Test 3.1: x^2+5x+6 => Delta", delta, 1);
                KiemTra("Test 3.2: => x1", x1, -2);
                KiemTra("Test 3.3: => x2", x2, -3);
            }

            // PT: x² - 2x + 1 = 0 → Delta=0, nghiệm kép x=1
            {
                double a=1, b=-2, c=1;
                double delta = b*b - 4*a*c;
                double x = -b / (2*a);
                KiemTra("Test 3.4: x^2-2x+1 => Delta", delta, 0);
                KiemTra("Test 3.5: => x (nghiem kep)", x, 1);
            }

            // PT: x² + 1 = 0 → Delta=-4<0, vô nghiệm
            {
                double a=1, b=0, c=1;
                double delta = b*b - 4*a*c;
                KiemTra("Test 3.6: x^2+1 => Delta", delta, -4);
                // delta < 0 → vô nghiệm
                total++;
                bool voNghiem = (delta < 0);
                if (voNghiem) pass++;
                Console.WriteLine("  Test 3.7: Vo nghiem (Delta<0) => {0}", voNghiem ? "PASS" : "FAIL");
            }

            // PT: 2x² - 7x + 3 = 0 → Delta=25, x1=3, x2=0.5
            {
                double a=2, b=-7, c=3;
                double delta = b*b - 4*a*c;
                double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2*a);
                KiemTra("Test 3.8: 2x^2-7x+3 => x1", x1, 3);
                KiemTra("Test 3.9: => x2", x2, 0.5);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 4: ĐỌC THÁNG TIẾNG ANH
        // ===================================================================
        static void TestThangTiengAnh()
        {
            Console.WriteLine("--- Test Bai 4: Doc thang tieng Anh ---");

            string[] tenThang = { "", "January", "February", "March", "April",
                "May", "June", "July", "August", "September",
                "October", "November", "December" };

            // Test tất cả 12 tháng
            string[] mongDoi = { "January", "February", "March", "April",
                "May", "June", "July", "August", "September",
                "October", "November", "December" };

            for (int i = 0; i < 12; i++)
            {
                KiemTra($"Test 4.{i+1}: Thang {i+1}", tenThang[i+1], mongDoi[i]);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // HÀM MAIN
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  TEST CASE - CHUONG 3: RE NHANH           ");
            Console.WriteLine("============================================\n");

            TestMaxMin5So();
            TestGiaTriHamSo1();
            TestPhuongTrinhBac2();
            TestThangTiengAnh();

            Console.WriteLine("============================================");
            Console.WriteLine("  KET QUA TONG: {0}/{1} PASS", pass, total);
            if (pass == total)
                Console.WriteLine("  >>> TAT CA TEST CASE DEU DUNG! <<<");
            else
                Console.WriteLine("  >>> CO {0} TEST CASE SAI! <<<", total - pass);
            Console.WriteLine("============================================");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.Read();
        }
    }
}
