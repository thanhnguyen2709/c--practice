using System;

namespace Lab6
{
    // ===================================================================
    // BAI 2: XU LY CHU SO (1)
    // Nhap so nguyen n. Hay:
    //   (a) Cho biet chu so thu k (tinh tu trai sang)
    //   (b) Tong cac chu so le
    //   (c) Tim chu so le nho nhat va lon nhat
    // Vi du: n = 182345, k = 2 => chu so o vi tri 2 la 8
    //   Tong chu so le = 1 + 3 + 5 = 9
    //   Chu so le nho nhat = 1, lon nhat = 5
    // ===================================================================
    static class XuLyChuSo1
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 2: XU LY CHU SO (1) ---\n");

            int n = NhapLieu.NhapSoNguyen("Moi ban nhap so nguyen n: ", 1, int.MaxValue);
            string s = n.ToString();

            int k = NhapLieu.NhapSoNguyen("Moi ban nhap vi tri k: ", 1, s.Length);

            // (a) Chu so thu k (tinh tu trai)
            int chuSoK = s[k - 1] - '0';
            Console.WriteLine($"Chu so o vi tri {k} (tinh tu trai) cua {n} la {chuSoK}.");

            // (b) Tong cac chu so le
            int tongLe = 0;
            foreach (char c in s)
            {
                int d = c - '0';
                if (d % 2 != 0)
                    tongLe += d;
            }
            Console.WriteLine($"Tong cac chu so le cua {n} la {tongLe}.");

            // (c) Tim chu so le nho nhat va lon nhat
            int minLe = int.MaxValue;
            int maxLe = int.MinValue;
            foreach (char c in s)
            {
                int d = c - '0';
                if (d % 2 != 0)
                {
                    if (d < minLe) minLe = d;
                    if (d > maxLe) maxLe = d;
                }
            }

            if (minLe == int.MaxValue)
                Console.WriteLine($"{n} khong co chu so le.");
            else
                Console.WriteLine($"{n} co chu so le nho nhat la {minLe} va lon nhat la {maxLe}.");
        }
    }
}
