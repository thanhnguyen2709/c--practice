/*
 * ============================================================
 * CHUONG 4: CAU LENH CHON LUA
 * ============================================================
 * Tac gia : Nguyen Truong Thanh
 * Ngay viet: 8/9/2026
 * Cach chay: dotnet run Chuong4_CauLenhChonLua.cs
 * ============================================================
 * Bai 1: Diem trung binh      - if/else xep loai
 * Bai 2: Tinh tien nuoc       - if/else tinh luy tien
 * Bai 3: Ngay sau              - switch/case xac dinh ngay
 * Bai 4: Phan loai tam giac   - if/else phan loai hinh
 * ============================================================
 */

using System;

namespace LTCsharp
{
    class Chuong4_CauLenhChonLua
    {
        // ===================================================================
        // BAI 1: DIEM TRUNG BINH
        // DTB = (Toan*2 + Ly*3 + Hoa) / 6
        // >=8: Gioi, >=6.5: Kha, >=5: Trung binh, <5: Yeu
        // ===================================================================
        static void DiemTrungBinh()
        {
            Console.WriteLine("--- Bai 1: Diem trung binh ---");

            Console.Write("Nhap diem Toan: ");
            double toan = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Ly: ");
            double ly = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Hoa: ");
            double hoa = double.Parse(Console.ReadLine());

            // Tinh diem trung binh co trong so
            double dtb = (toan * 2 + ly * 3 + hoa) / 6.0;

            // Xep loai theo DTB
            string xepLoai;
            if (dtb >= 8)
                xepLoai = "Gioi";
            else if (dtb >= 6.5)
                xepLoai = "Kha";
            else if (dtb >= 5)
                xepLoai = "Trung binh";
            else
                xepLoai = "Yeu";

            Console.WriteLine("Diem trung binh: {0:F2}", dtb);
            Console.WriteLine("Xep loai: {0}", xepLoai);
        }

        // ===================================================================
        // BAI 2: TINH TIEN NUOC
        // Muc 1: 4m3/nguoi x 4.400d
        // Muc 2: 2m3/nguoi x 8.300d
        // Muc 3: con lai   x 10.500d
        // Cong VAT 5% + BVMT 10% => nhan 1.15
        // ===================================================================
        static void TienNuoc()
        {
            Console.WriteLine("--- Bai 2: Tinh tien nuoc ---");

            Console.Write("Nhap luong nuoc su dung (m3): ");
            int luongNuoc = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguoi trong ho: ");
            int soNguoi = int.Parse(Console.ReadLine());

            // Tinh dinh muc theo so nguoi
            int mucRe = 4 * soNguoi;       // Muc 1: 4m3/nguoi
            int mucTrung = 2 * soNguoi;     // Muc 2: 2m3/nguoi

            double tien = 0;
            int conLai = luongNuoc;

            // Muc 1: 4.400d/m3
            if (conLai > 0)
            {
                int m3 = Math.Min(conLai, mucRe);
                tien += m3 * 4400;
                conLai -= m3;
            }

            // Muc 2: 8.300d/m3
            if (conLai > 0)
            {
                int m3 = Math.Min(conLai, mucTrung);
                tien += m3 * 8300;
                conLai -= m3;
            }

            // Muc 3: 10.500d/m3
            if (conLai > 0)
            {
                tien += conLai * 10500;
            }

            // Cong VAT 5% + BVMT 10% = 15%
            tien = tien * 1.15;

            Console.WriteLine("Tien nuoc phai tra: {0:N0} dong", tien);
        }

        // ===================================================================
        // BAI 3: NGAY SAU
        // Nhap ngay/thang/nam -> In ra ngay hom sau
        // Xu ly: cuoi thang, nam nhuan, cuoi nam
        // ===================================================================
        static void NgaySau()
        {
            Console.WriteLine("--- Bai 3: Ngay sau ---");

            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            // Tim so ngay toi da cua thang
            int soNgayMax;
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    soNgayMax = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    soNgayMax = 30;
                    break;
                case 2:
                    // Kiem tra nam nhuan
                    bool nhuan = (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);
                    soNgayMax = nhuan ? 29 : 28;
                    break;
                default:
                    soNgayMax = 30;
                    break;
            }

            // Tinh ngay hom sau
            if (ngay < soNgayMax)
            {
                ngay++;
            }
            else
            {
                ngay = 1;
                if (thang < 12)
                    thang++;
                else
                {
                    thang = 1;
                    nam++;
                }
            }

            Console.WriteLine("Ngay hom sau: {0}/{1}/{2}", ngay, thang, nam);
        }

        // ===================================================================
        // BAI 4: PHAN LOAI TAM GIAC
        // Nhap 3 canh -> Phan loai: deu, can, vuong, vuong can, thuong
        // Hoac "Khong phai tam giac"
        // ===================================================================
        static void PhanLoaiTamGiac()
        {
            Console.WriteLine("--- Bai 4: Phan loai tam giac ---");

            Console.Write("Nhap canh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            double c = double.Parse(Console.ReadLine());

            // Kiem tra dieu kien tam giac
            if (!(a + b > c && b + c > a && a + c > b))
            {
                Console.WriteLine("Ket qua: Khong phai tam giac");
                return;
            }

            // Tinh binh phuong cac canh
            double a2 = a * a, b2 = b * b, c2 = c * c;

            // Kiem tra cac loai
            bool deu = (a == b && b == c);
            bool can = (a == b) || (b == c) || (a == c);
            double eps = 1e-9;
            bool vuong = Math.Abs(a2 + b2 - c2) < eps || Math.Abs(b2 + c2 - a2) < eps || Math.Abs(a2 + c2 - b2) < eps;

            // Phan loai theo thu tu uu tien
            string loai;
            if (deu)
                loai = "deu";
            else if (can && vuong)
                loai = "vuong can";
            else if (can)
                loai = "can";
            else if (vuong)
                loai = "vuong";
            else
                loai = "thuong";

            Console.WriteLine("Tam giac: {0}", loai);
        }

        // ===================================================================
        // HAM MAIN - DIEM BAT DAU CHUONG TRINH
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 4: CAU LENH CHON LUA              ");
            Console.WriteLine("============================================");

            Console.WriteLine("1. Diem trung binh          (DiemTrungBinh)");
            Console.WriteLine("2. Tinh tien nuoc           (TienNuoc)");
            Console.WriteLine("3. Ngay sau                 (NgaySau)");
            Console.WriteLine("4. Phan loai tam giac       (PhanLoaiTamGiac)");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (chon)
            {
                case 1: DiemTrungBinh(); break;
                case 2: TienNuoc(); break;
                case 3: NgaySau(); break;
                case 4: PhanLoaiTamGiac(); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.Read();
        }
    }
}
