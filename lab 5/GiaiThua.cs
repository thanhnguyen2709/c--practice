using System;

namespace Lab5
{
    // ===================================================================
    // BAI 1: TINH GIAI THUA
    // Nhap so nguyen duong n (1 <= n <= 12). Tinh n! = 1.2.3...n
    // Kien thuc: vong lap for, tich luy tich
    // Gioi han n <= 12 vi 13! vuot qua kieu int
    // ===================================================================
    static class GiaiThua
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 1: TINH GIAI THUA ---\n");

            int n = NhapLieu.NhapSoNguyen("Moi ban nhap so n: ", 1, 12);

            long gt = 1;
            string chuoi = "";   // Chuoi hien thi dang 1.2.3...n
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
                chuoi += (i == 1 ? "" : ".") + i;
            }

            Console.WriteLine($"{n}! = {chuoi} = {gt}.");
        }
    }
}
