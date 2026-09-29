/*
 * ============================================================
 * TEST CASE - CHƯƠNG 4: CÂU LỆNH CHỌN LỰA
 * ============================================================
 * Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Cách chạy: dotnet run TestChuong4.cs
 * ============================================================
 */

using System;

namespace LTCsharp.Test
{
    class TestChuong4
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
        // TEST BÀI 1: ĐIỂM TRUNG BÌNH
        // DTB = (Toán*2 + Lý*3 + Hóa) / 6
        // >=8: Gioi, >=6.5: Kha, >=5: Trung binh, <5: Yeu
        // ===================================================================
        static void TestDiemTrungBinh()
        {
            Console.WriteLine("--- Test Bai 1: Diem trung binh ---");

            // Hàm tính DTB và xếp loại
            string XepLoai(double dtb)
            {
                if (dtb >= 8) return "Gioi";
                if (dtb >= 6.5) return "Kha";
                if (dtb >= 5) return "Trung binh";
                return "Yeu";
            }

            // Test: Toán=7, Lý=6, Hóa=8 → DTB=(14+18+8)/6=6.67 → Khá
            {
                double dtb = (7*2 + 6*3 + 8) / 6.0;
                KiemTra("Test 1.1: T=7,L=6,H=8 => DTB", dtb, 6.67);
                KiemTra("Test 1.2: => Xep loai", XepLoai(dtb), "Kha");
            }

            // Test: Toán=9, Lý=8, Hóa=10 → DTB=(18+24+10)/6=8.67 → Giỏi
            {
                double dtb = (9*2 + 8*3 + 10) / 6.0;
                KiemTra("Test 1.3: T=9,L=8,H=10 => DTB", dtb, 8.67);
                KiemTra("Test 1.4: => Xep loai", XepLoai(dtb), "Gioi");
            }

            // Test: Toán=3, Lý=4, Hóa=2 → DTB=(6+12+2)/6=3.33 → Yếu
            {
                double dtb = (3*2 + 4*3 + 2) / 6.0;
                KiemTra("Test 1.5: T=3,L=4,H=2 => DTB", dtb, 3.33);
                KiemTra("Test 1.6: => Xep loai", XepLoai(dtb), "Yeu");
            }

            // Test: Toán=5, Lý=5, Hóa=5 → DTB=(10+15+5)/6=5.0 → Trung bình
            {
                double dtb = (5*2 + 5*3 + 5) / 6.0;
                KiemTra("Test 1.7: T=5,L=5,H=5 => DTB", dtb, 5.0);
                KiemTra("Test 1.8: => Xep loai", XepLoai(dtb), "Trung binh");
            }

            // Test biên: DTB = 8.0 → Giỏi (đúng biên)
            {
                double dtb = 8.0;
                KiemTra("Test 1.9: DTB=8.0 => Xep loai", XepLoai(dtb), "Gioi");
            }

            // Test biên: DTB = 6.5 → Khá (đúng biên)
            {
                double dtb = 6.5;
                KiemTra("Test 1.10: DTB=6.5 => Xep loai", XepLoai(dtb), "Kha");
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 2: TÍNH TIỀN NƯỚC
        // Mức 1: 4m³/người × 4.400đ, Mức 2: 2m³/người × 8.300đ
        // Mức 3: còn lại × 10.500đ. Cộng VAT 5% + BVMT 10%
        // ===================================================================
        static void TestTienNuoc()
        {
            Console.WriteLine("--- Test Bai 2: Tinh tien nuoc ---");

            // Hàm tính tiền nước
            double TinhTienNuoc(int luongNuoc, int soNguoi)
            {
                int mucRe = 4 * soNguoi;
                int mucTrung = 2 * soNguoi;
                double tien = 0;
                int conLai = luongNuoc;

                if (conLai > 0)
                {
                    int m3 = Math.Min(conLai, mucRe);
                    tien += m3 * 4400;
                    conLai -= m3;
                }
                if (conLai > 0)
                {
                    int m3 = Math.Min(conLai, mucTrung);
                    tien += m3 * 8300;
                    conLai -= m3;
                }
                if (conLai > 0)
                {
                    tien += conLai * 10500;
                }

                return tien * 1.15; // +5% VAT + 10% BVMT
            }

            // Test: 3 m³, 1 người → 3×4400 = 13200 × 1.15 = 15180
            {
                double tien = TinhTienNuoc(3, 1);
                KiemTra("Test 2.1: 3m3, 1 nguoi", tien, 15180);
            }

            // Test: 5 m³, 1 người → 4×4400 + 1×8300 = 25900 × 1.15 = 29785
            {
                double tien = TinhTienNuoc(5, 1);
                KiemTra("Test 2.2: 5m3, 1 nguoi", tien, 29785);
            }

            // Test: 10 m³, 1 người → 4×4400 + 2×8300 + 4×10500 = 76200 × 1.15 = 87630
            {
                double tien = TinhTienNuoc(10, 1);
                KiemTra("Test 2.3: 10m3, 1 nguoi", tien, 87630);
            }

            // Test: 0 m³ → 0 đồng
            {
                double tien = TinhTienNuoc(0, 1);
                KiemTra("Test 2.4: 0m3", tien, 0);
            }

            // Test: 12 m³, 2 người → 8×4400 + 4×8300 = 68400 × 1.15 = 78660
            {
                double tien = TinhTienNuoc(12, 2);
                KiemTra("Test 2.5: 12m3, 2 nguoi", tien, 78660);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 3: NGÀY SAU
        // ===================================================================
        static void TestNgaySau()
        {
            Console.WriteLine("--- Test Bai 3: Ngay sau ---");

            // Hàm tính ngày sau
            (int, int, int) TinhNgaySau(int ngay, int thang, int nam)
            {
                int soNgayMax;
                switch (thang)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        soNgayMax = 31; break;
                    case 4: case 6: case 9: case 11:
                        soNgayMax = 30; break;
                    case 2:
                        bool nhuan = (nam%400==0) || (nam%4==0 && nam%100!=0);
                        soNgayMax = nhuan ? 29 : 28; break;
                    default: soNgayMax = 30; break;
                }

                if (ngay < soNgayMax) { ngay++; }
                else { ngay = 1; if (thang < 12) thang++; else { thang = 1; nam++; } }
                return (ngay, thang, nam);
            }

            // Test: 15/3/2025 → 16/3/2025 (ngày thường)
            {
                var (n, t, na) = TinhNgaySau(15, 3, 2025);
                KiemTra("Test 3.1: 15/3/2025 => ngay", n, 16);
                KiemTra("Test 3.2: => thang", t, 3);
            }

            // Test: 31/1/2015 → 1/2/2015 (cuối tháng 31 ngày)
            {
                var (n, t, na) = TinhNgaySau(31, 1, 2015);
                KiemTra("Test 3.3: 31/1/2015 => ngay", n, 1);
                KiemTra("Test 3.4: => thang", t, 2);
            }

            // Test: 30/4/2025 → 1/5/2025 (cuối tháng 30 ngày)
            {
                var (n, t, na) = TinhNgaySau(30, 4, 2025);
                KiemTra("Test 3.5: 30/4/2025 => ngay", n, 1);
                KiemTra("Test 3.6: => thang", t, 5);
            }

            // Test: 28/2/2024 → 29/2/2024 (năm nhuận)
            {
                var (n, t, na) = TinhNgaySau(28, 2, 2024);
                KiemTra("Test 3.7: 28/2/2024 => ngay", n, 29);
                KiemTra("Test 3.8: => thang", t, 2);
            }

            // Test: 29/2/2024 → 1/3/2024 (cuối tháng 2 nhuận)
            {
                var (n, t, na) = TinhNgaySau(29, 2, 2024);
                KiemTra("Test 3.9: 29/2/2024 => ngay", n, 1);
                KiemTra("Test 3.10: => thang", t, 3);
            }

            // Test: 28/2/2023 → 1/3/2023 (không nhuận)
            {
                var (n, t, na) = TinhNgaySau(28, 2, 2023);
                KiemTra("Test 3.11: 28/2/2023 => ngay", n, 1);
                KiemTra("Test 3.12: => thang", t, 3);
            }

            // Test: 31/12/2025 → 1/1/2026 (cuối năm)
            {
                var (n, t, na) = TinhNgaySau(31, 12, 2025);
                KiemTra("Test 3.13: 31/12/2025 => ngay", n, 1);
                KiemTra("Test 3.14: => thang", t, 1);
                KiemTra("Test 3.15: => nam", na, 2026);
            }

            // Test: 28/2/1900 → 1/3/1900 (chia hết 100 nhưng ko chia hết 400 → ko nhuận)
            {
                var (n, t, na) = TinhNgaySau(28, 2, 1900);
                KiemTra("Test 3.16: 28/2/1900 => ngay", n, 1);
                KiemTra("Test 3.17: => thang", t, 3);
            }

            Console.WriteLine();
        }

        // ===================================================================
        // TEST BÀI 4: PHÂN LOẠI TAM GIÁC
        // ===================================================================
        static void TestPhanLoaiTamGiac()
        {
            Console.WriteLine("--- Test Bai 4: Phan loai tam giac ---");

            // Hàm phân loại
            string PhanLoai(double a, double b, double c)
            {
                if (!(a+b>c && b+c>a && a+c>b)) return "Khong phai TG";
                double a2=a*a, b2=b*b, c2=c*c;
                bool deu = (a==b && b==c);
                bool can = (a==b) || (b==c) || (a==c);
                double eps = 1e-9;
                bool vuong = Math.Abs(a2+b2-c2) < eps || Math.Abs(b2+c2-a2) < eps || Math.Abs(a2+c2-b2) < eps;
                if (deu) return "deu";
                if (can && vuong) return "vuong can";
                if (can) return "can";
                if (vuong) return "vuong";
                return "thuong";
            }

            // Test: (3, 4, 5) → vuông
            KiemTra("Test 4.1: (3,4,5)", PhanLoai(3,4,5), "vuong");

            // Test: (5, 3, 4) → vuông (thứ tự khác)
            KiemTra("Test 4.2: (5,3,4)", PhanLoai(5,3,4), "vuong");

            // Test: (3, 3, 3) → đều
            KiemTra("Test 4.3: (3,3,3)", PhanLoai(3,3,3), "deu");

            // Test: (5, 5, 3) → cân
            KiemTra("Test 4.4: (5,5,3)", PhanLoai(5,5,3), "can");

            // Test: (1, 1, Math.Sqrt(2)) → vuông cân
            KiemTra("Test 4.5: (1,1,√2)", PhanLoai(1,1,Math.Sqrt(2)), "vuong can");

            // Test: (3, 4, 6) → thường
            KiemTra("Test 4.6: (3,4,6)", PhanLoai(3,4,6), "thuong");

            // Test: (1, 2, 10) → KHÔNG phải tam giác
            KiemTra("Test 4.7: (1,2,10)", PhanLoai(1,2,10), "Khong phai TG");

            // Test: (1, 1, 2) → KHÔNG phải tam giác (tổng 2 cạnh = cạnh còn lại)
            KiemTra("Test 4.8: (1,1,2)", PhanLoai(1,1,2), "Khong phai TG");

            Console.WriteLine();
        }

        // ===================================================================
        // HÀM MAIN
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  TEST CASE - CHUONG 4: CAU LENH CHON LUA  ");
            Console.WriteLine("============================================\n");

            TestDiemTrungBinh();
            TestTienNuoc();
            TestNgaySau();
            TestPhanLoaiTamGiac();

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
