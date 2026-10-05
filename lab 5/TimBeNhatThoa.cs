using System;

namespace Lab5
{
    // ===================================================================
    // BAI 4: TIM BE NHAT THOA
    // Tim so nguyen duong n be nhat thoa: 1 + 1/2 + 1/3 + ... + 1/n > a
    // Kien thuc: vong lap do-while (luon cong it nhat 1 so hang)
    // Luu y: tong dieu hoa tang rat cham (~ ln n), a = 20 can ~2.7e8 lan lap
    //   => gioi han a <= 20 de chuong trinh chay nhanh.
    // ===================================================================
    static class TimBeNhatThoa
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 4: TIM BE NHAT THOA ---\n");

            double a = NhapLieu.NhapSoThuc("Moi ban nhap so a: ",
                x => x <= 20, "Vui long nhap a <= 20 (tong tang rat cham)!");

            double s = 0;
            long n = 0;
            do
            {
                n++;
                s += 1.0 / n;
            } while (s <= a);

            Console.WriteLine($"So nguyen duong n be nhat thoa 1 + 1/2 + ... + 1/n > {a} la n = {n}.");
        }
    }
}
