using System;
using System.Globalization;

namespace Lab6
{
    // ===================================================================
    // HAM HO TRO NHAP LIEU (kiem tra du lieu hop le, nhap lai neu sai)
    // ===================================================================
    static class NhapLieu
    {
        public static int NhapSoNguyen(string loiNhac, int min, int max)
        {
            while (true)
            {
                Console.Write(loiNhac);
                if (int.TryParse(Console.ReadLine(), out int n) && n >= min && n <= max)
                    return n;
                Console.WriteLine(max == int.MaxValue
                    ? $"  Loi: vui long nhap so nguyen >= {min}!"
                    : $"  Loi: vui long nhap so nguyen trong [{min}, {max}]!");
            }
        }

        public static double NhapSoThuc(string loiNhac, Func<double, bool> dieuKien, string thongBaoLoi)
        {
            while (true)
            {
                Console.Write(loiNhac);
                string s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                {
                    if (dieuKien(x)) return x;
                    Console.WriteLine("  Loi: " + thongBaoLoi);
                }
                else
                    Console.WriteLine("  Loi: vui long nhap so thuc hop le!");
            }
        }
    }

    // ===================================================================
    // MENU CHINH LAB 6
    // ===================================================================
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; // In so thuc voi dau '.'

            while (true)
            {
                Console.WriteLine("\n========== LAB 6 - BAI TAP CO BAN ==========");
                Console.WriteLine("1. In hinh chu I va chu U");
                Console.WriteLine("2. Xu ly chu so (1)");
                Console.WriteLine("3. Phan tich thua so nguyen to (cai tien)");
                Console.WriteLine("4. Kiem tra so hoan hao");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon bai: ");

                string? chon = Console.ReadLine();
                Console.WriteLine();
                switch (chon)
                {
                    case "1": InChuIvaU.Run(); break;
                    case "2": XuLyChuSo1.Run(); break;
                    case "3": PhanTichThuaSo1.Run(); break;
                    case "4": KiemTraSoHoanHao.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lua chon khong hop le!"); break;
                }
            }
        }
    }
}
