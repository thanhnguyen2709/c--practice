/*
 * ============================================================
 * TEST CASE - CHƯƠNG 2: NHẬP XUẤT DỮ LIỆU CƠ BẢN
 * ============================================================
 * Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Cách chạy: dotnet run TestChuong2.cs
 * ============================================================
 */

using System;

namespace LTCsharp.Test
{
    class TestChuong2
    {
        static int pass = 0, total = 0;

        static void KiemTra(string tenTest, double ketQua, double mongDoi, double saiSo = 0.1)
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
        // TEST BÀI 2: TÍNH DIỆN TÍCH VÀ CHU VI HÌNH TRÒN
        // S = 3.14 * R², P = 2 * 3.14 * R
        // ===================================================================
        static void TestHinhTron()
        {
            Console.WriteLine("--- Test Bai 2: Hinh tron ---");
            const double PI = 3.14;

            // Test R = 5 → S = 78.5, P = 31.4
            {
                double R = 5;
                double S = PI * R * R;
                double P = 2 * PI * R;
                KiemTra("Test 2.1: R=5 => S", S, 78.5);
                KiemTra("Test 2.2: R=5 => P", P, 31.4);
            }

            // Test R = 10 → S = 314.0, P = 62.8
            {
                double R = 10;
                double S = PI * R * R;
                double P = 2 * PI * R;
                KiemTra("Test 2.3: R=10 => S", S, 314.0);
                KiemTra("Test 2.4: R=10 => P", P, 62.8);
            }

            // Test R = 0 → S = 0, P = 0 (trường hợp biên)
            {
                double R = 0;
                double S = PI * R * R;
                double P = 2 * PI * R;
                KiemTra("Test 2.5: R=0 => S", S, 0);
                KiemTra("Test 2.6: R=0 => P", P, 0);
            }

            // Test R = 1 → S = 3.14, P = 6.28
            {
                double R = 1;
                double S = PI * R * R;
                double P = 2 * PI * R;
                KiemTra("Test 2.7: R=1 => S", S, 3.14);
                KiemTra("Test 2.8: R=1 => P", P, 6.28);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 3: ĐỔI SANG GIÂY
        // tongGiay = h * 3600 + m * 60 + s
        // ===================================================================
        static void TestDoiSangGiay()
        {
            Console.WriteLine("--- Test Bai 3: Doi sang giay ---");

            // Test 1h 20m 10s = 4810 giây
            {
                int h = 1, m = 20, s = 10;
                int tongGiay = h * 3600 + m * 60 + s;
                KiemTra("Test 3.1: 1h20m10s", tongGiay, 4810);
            }

            // Test 0h 0m 0s = 0 giây (trường hợp biên)
            {
                int h = 0, m = 0, s = 0;
                int tongGiay = h * 3600 + m * 60 + s;
                KiemTra("Test 3.2: 0h0m0s", tongGiay, 0);
            }

            // Test 2h 30m 45s = 9045 giây
            {
                int h = 2, m = 30, s = 45;
                int tongGiay = h * 3600 + m * 60 + s;
                KiemTra("Test 3.3: 2h30m45s", tongGiay, 9045);
            }

            // Test 24h 0m 0s = 86400 giây (1 ngày)
            {
                int h = 24, m = 0, s = 0;
                int tongGiay = h * 3600 + m * 60 + s;
                KiemTra("Test 3.4: 24h0m0s", tongGiay, 86400);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 4: ĐỔI SANG GIỜ PHÚT GIÂY
        // giờ = t / 3600, phút = (t % 3600) / 60, giây = t % 60
        // ===================================================================
        static void TestDoiSangGioPhutGiay()
        {
            Console.WriteLine("--- Test Bai 4: Doi sang gio phut giay ---");

            // Test 4810s = 1:20:10
            {
                int t = 4810;
                int gio = t / 3600, phut = (t % 3600) / 60, giay = t % 60;
                KiemTra("Test 4.1: 4810s => gio", gio, 1);
                KiemTra("Test 4.2: 4810s => phut", phut, 20);
                KiemTra("Test 4.3: 4810s => giay", giay, 10);
            }

            // Test 3661s = 1:1:1
            {
                int t = 3661;
                int gio = t / 3600, phut = (t % 3600) / 60, giay = t % 60;
                KiemTra("Test 4.4: 3661s => gio", gio, 1);
                KiemTra("Test 4.5: 3661s => phut", phut, 1);
                KiemTra("Test 4.6: 3661s => giay", giay, 1);
            }

            // Test 59s = 0:0:59
            {
                int t = 59;
                int gio = t / 3600, phut = (t % 3600) / 60, giay = t % 60;
                KiemTra("Test 4.7: 59s => gio", gio, 0);
                KiemTra("Test 4.8: 59s => phut", phut, 0);
                KiemTra("Test 4.9: 59s => giay", giay, 59);
            }

            // Test 0s = 0:0:0 (trường hợp biên)
            {
                int t = 0;
                int gio = t / 3600, phut = (t % 3600) / 60, giay = t % 60;
                KiemTra("Test 4.10: 0s => gio", gio, 0);
                KiemTra("Test 4.11: 0s => phut", phut, 0);
                KiemTra("Test 4.12: 0s => giay", giay, 0);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // HÀM MAIN
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  TEST CASE - CHUONG 2: NHAP XUAT          ");
            Console.WriteLine("============================================\n");

            TestHinhTron();
            TestDoiSangGiay();
            TestDoiSangGioPhutGiay();

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
