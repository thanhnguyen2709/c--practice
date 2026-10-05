using System;
using System.Globalization;

namespace Lab5
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
    // MENU CHINH LAB 5
    // ===================================================================
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; // In so thuc voi dau '.'

            while (true)
            {
                Console.WriteLine("\n========== LAB 5 - VONG LAP ==========");
                Console.WriteLine("1. Tinh giai thua");
                Console.WriteLine("2. Gia tri bieu thuc");
                Console.WriteLine("3. Tong phan so (sai so)");
                Console.WriteLine("4. Tim be nhat thoa");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon bai: ");

                string? chon = Console.ReadLine();
                Console.WriteLine();
                switch (chon)
                {
                    case "1": GiaiThua.Run(); break;
                    case "2": GiaTriBieuThuc.Run(); break;
                    case "3": TongPhanSoSaiSo.Run(); break;
                    case "4": TimBeNhatThoa.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lua chon khong hop le!"); break;
                }
            }
        }
    }
}
