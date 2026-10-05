using System;

namespace Lab5
{
    // ===================================================================
    // BAI 2: GIA TRI BIEU THUC
    // S1 = 1/1 + 1/2 + ... + 1/n
    // S2 = 1/n - 1/(n-1) + 1/(n-2) - ... + (-1)^(n+1) * 1/1
    // Kien thuc: vong lap for, dao dau xen ke
    // S2: duyet i = 0..n-1, so hang thu i co mau (n - i), dau (-1)^i
    //     => so hang cuoi (i = n-1) co dau (-1)^(n-1) = (-1)^(n+1), mau 1. Dung de bai.
    // ===================================================================
    static class GiaTriBieuThuc
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 2: GIA TRI BIEU THUC ---\n");

            int n = NhapLieu.NhapSoNguyen("Moi ban nhap so nguyen n: ", 1, int.MaxValue);

            // Tinh S1
            double s1 = 0;
            for (int i = 1; i <= n; i++)
                s1 += 1.0 / i;

            // Tinh S2
            double s2 = 0;
            int dau = 1;               // Dau cua so hang dau tien la +
            for (int i = 0; i < n; i++)
            {
                s2 += dau * 1.0 / (n - i);
                dau = -dau;            // Dao dau cho so hang tiep theo
            }

            Console.WriteLine($"S1(n={n}) = {s1:F4}.");
            Console.WriteLine($"S2(n={n}) = {s2:F4}");
        }
    }
}
