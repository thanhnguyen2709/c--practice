using System;

namespace Lab6
{
    // ===================================================================
    // BAI 3: PHAN TICH THUA SO NGUYEN TO (CAI TIEN)
    // Nhap so nguyen n (n > 1). Phan tich n thanh thua so nguyen to.
    // Vi du: 100 = 2^2 x 5^2
    // Cai tien: chi can thu chia tu 2 den sqrt(n), neu n > 1 sau khi chia
    //   het thi n la so nguyen to con lai.
    // ===================================================================
    static class PhanTichThuaSo1
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 3: PHAN TICH THUA SO NGUYEN TO ---\n");

            int n = NhapLieu.NhapSoNguyen("Moi ban nhap so nguyen n: ", 2, int.MaxValue);
            int goc = n;

            string ketQua = "";
            int d = 2;

            while ((long)d * d <= n)
            {
                if (n % d == 0)
                {
                    int soMu = 0;
                    while (n % d == 0)
                    {
                        soMu++;
                        n /= d;
                    }

                    if (ketQua.Length > 0) ketQua += " x ";
                    ketQua += soMu == 1 ? $"{d}" : $"{d}^{soMu}";
                }
                d++;
            }

            // Neu n > 1 thi n la thua so nguyen to con lai
            if (n > 1)
            {
                if (ketQua.Length > 0) ketQua += " x ";
                ketQua += $"{n}";
            }

            Console.WriteLine($"{goc} = {ketQua}");
        }
    }
}
