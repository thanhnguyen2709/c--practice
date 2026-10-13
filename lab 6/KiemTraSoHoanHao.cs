using System;

namespace Lab6
{
    // ===================================================================
    // BAI 4: KIEM TRA SO HOAN HAO
    // So tu nhien n la so hoan hao neu tong cac uoc tu nhien cua no
    // (khong ke chinh no) bang n.
    // Vi du: 6 = 1 + 2 + 3 la so hoan hao.
    // ===================================================================
    static class KiemTraSoHoanHao
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 4: KIEM TRA SO HOAN HAO ---\n");

            int n = NhapLieu.NhapSoNguyen("Moi ban nhap n: ", 1, int.MaxValue);

            // Tim tong cac uoc (khong ke chinh n)
            int tongUoc = 0;
            string dsUoc = "";

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tongUoc += i;
                    if (dsUoc.Length > 0) dsUoc += " + ";
                    dsUoc += i;
                }
            }

            if (tongUoc == n)
                Console.WriteLine($"{n} = {dsUoc} la so hoan hao.");
            else
                Console.WriteLine($"{n} khong la so hoan hao.");
        }
    }
}
