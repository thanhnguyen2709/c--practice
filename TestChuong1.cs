/*
 * ============================================================
 * TEST CASE - CHƯƠNG 1: BÀI TẬP CƠ BẢN - BIỂU THỨC
 * ============================================================
 * Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Cách chạy: dotnet run TestChuong1.cs
 * ============================================================
 * File test này GỌI TRỰC TIẾP các hàm tính toán từ
 * Chuong1_BieuThuc.cs để kiểm tra kết quả.
 *
 * Liên kết:
 *   TestTongDoan()      → gọi Chuong1_BieuThuc.TinhTongDoan(a, b)
 *   TestLuyThuaNhanh1() → gọi Chuong1_BieuThuc.TinhLuyThua(a)
 *   TestBieuThucNhanh1()→ gọi Chuong1_BieuThuc.TinhBieuThuc(x)
 *   TestTimQui()        → gọi Chuong1_BieuThuc.TinhQui(thang)
 * ============================================================
 */

using System;
// Dùng alias để truy cập lớp Chuong1_BieuThuc từ namespace LTCsharp.Buoi1
using BaiTap = LTCsharp.Buoi1.Chuong1_BieuThuc;

namespace LTCsharp.Test
{
    class TestChuong1
    {
        // Biến đếm toàn cục: số test PASS và tổng số test
        static int pass = 0, total = 0;

        // Hàm hỗ trợ: kiểm tra và in kết quả 1 test case (so sánh số)
        static void KiemTra(string tenTest, double ketQua, double mongDoi, double saiSo = 0.01)
        {
            total++;
            bool dung = (Math.Abs(ketQua - mongDoi) <= saiSo);
            if (dung) pass++;
            Console.WriteLine("  {0}: {1} (mong doi: {2}) => {3}",
                tenTest, ketQua, mongDoi, dung ? "PASS" : "FAIL");
        }

        // ===================================================================
        // TEST BÀI 1: TÍNH TỔNG ĐOẠN
        // Gọi trực tiếp: BaiTap.TinhTongDoan(a, b)
        // ===================================================================
        static void TestTongDoan()
        {
            Console.WriteLine("--- Test Bai 1: Tinh tong doan ---");

            // Test 1.1: Tổng đoạn [3, 5] = 3 + 4 + 5 = 12
            KiemTra("Test 1.1: Tong[3,5]", BaiTap.TinhTongDoan(3, 5), 12);

            // Test 1.2: Tổng đoạn [1, 10] = 55
            KiemTra("Test 1.2: Tong[1,10]", BaiTap.TinhTongDoan(1, 10), 55);

            // Test 1.3: Tổng đoạn [5, 5] = 5 (chỉ 1 phần tử)
            KiemTra("Test 1.3: Tong[5,5]", BaiTap.TinhTongDoan(5, 5), 5);

            // Test 1.4: Tổng đoạn [1, 100] = 5050
            KiemTra("Test 1.4: Tong[1,100]", BaiTap.TinhTongDoan(1, 100), 5050);

            // Test 1.5: Tổng đoạn [-3, 3] = -3-2-1+0+1+2+3 = 0
            KiemTra("Test 1.5: Tong[-3,3]", BaiTap.TinhTongDoan(-3, 3), 0);

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 2: LŨY THỪA NHANH 1
        // Gọi trực tiếp: BaiTap.TinhLuyThua(a) → trả về {a², a⁵, a¹⁷}
        // ===================================================================
        static void TestLuyThuaNhanh1()
        {
            Console.WriteLine("--- Test Bai 2: Luy thua nhanh 1 ---");

            // Test với a = 2: 2²=4, 2⁵=32, 2¹⁷=131072
            {
                double[] kq = BaiTap.TinhLuyThua(2);
                KiemTra("Test 2.1: 2^2", kq[0], 4);
                KiemTra("Test 2.2: 2^5", kq[1], 32);
                KiemTra("Test 2.3: 2^17", kq[2], 131072);
            }

            // Test với a = 3: 3²=9, 3⁵=243, 3¹⁷=129140163
            {
                double[] kq = BaiTap.TinhLuyThua(3);
                KiemTra("Test 2.4: 3^2", kq[0], 9);
                KiemTra("Test 2.5: 3^5", kq[1], 243);
                KiemTra("Test 2.6: 3^17", kq[2], 129140163);
            }

            // Test với a = 1: mọi lũy thừa đều = 1
            {
                double[] kq = BaiTap.TinhLuyThua(1);
                KiemTra("Test 2.7: 1^17", kq[2], 1);
            }

            // Test với a = 0: mọi lũy thừa đều = 0
            {
                double[] kq = BaiTap.TinhLuyThua(0);
                KiemTra("Test 2.8: 0^2", kq[0], 0);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 3: TÍNH BIỂU THỨC NHANH 1
        // Gọi trực tiếp: BaiTap.TinhBieuThuc(x)
        // f(x) = 1 + 2x + 3x² - 4x³
        // ===================================================================
        static void TestBieuThucNhanh1()
        {
            Console.WriteLine("--- Test Bai 3: Tinh bieu thuc nhanh 1 ---");

            // Test 3.1: f(0) = 1
            KiemTra("Test 3.1: f(0)", BaiTap.TinhBieuThuc(0), 1);

            // Test 3.2: f(1) = 1+2+3-4 = 2
            KiemTra("Test 3.2: f(1)", BaiTap.TinhBieuThuc(1), 2);

            // Test 3.3: f(3) = 1+6+27-108 = -74
            KiemTra("Test 3.3: f(3)", BaiTap.TinhBieuThuc(3), -74);

            // Test 3.4: f(-1) = 1-2+3+4 = 6
            KiemTra("Test 3.4: f(-1)", BaiTap.TinhBieuThuc(-1), 6);

            // Test 3.5: f(2) = 1+4+12-32 = -15
            KiemTra("Test 3.5: f(2)", BaiTap.TinhBieuThuc(2), -15);

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 4: TÌM QUÍ
        // Gọi trực tiếp: BaiTap.TinhQui(thang)
        // ===================================================================
        static void TestTimQui()
        {
            Console.WriteLine("--- Test Bai 4: Tim qui ---");

            // Test tất cả 12 tháng
            int[] quiMongDoi = { 1,1,1, 2,2,2, 3,3,3, 4,4,4 };
            for (int thang = 1; thang <= 12; thang++)
            {
                int qui = BaiTap.TinhQui(thang);
                KiemTra($"Test 4.{thang}: Thang {thang} => Qui", qui, quiMongDoi[thang - 1]);
            }

            // Test tháng không hợp lệ → trả về -1
            KiemTra("Test 4.13: Thang 0 => Qui", BaiTap.TinhQui(0), -1);
            KiemTra("Test 4.14: Thang 13 => Qui", BaiTap.TinhQui(13), -1);

            Console.WriteLine();
        }

        // ===================================================================
        // HÀM MAIN - CHẠY TẤT CẢ TEST
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  TEST CASE - CHUONG 1: BIEU THUC          ");
            Console.WriteLine("============================================\n");

            // Chạy test từng bài - GỌI TRỰC TIẾP hàm từ Chuong1_BieuThuc.cs
            TestTongDoan();
            TestLuyThuaNhanh1();
            TestBieuThucNhanh1();
            TestTimQui();

            // In tổng kết
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
