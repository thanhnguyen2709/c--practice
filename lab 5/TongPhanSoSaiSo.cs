using System;

namespace Lab5
{
    // ===================================================================
    // BAI 3: TONG PHAN SO (SAI SO)
    // S = 1/a + 1/(a+1) + ... + 1/(a+n) + ... cho den khi 1/(a+n) < epsilon
    // Kien thuc: vong lap while (khong biet truoc so lan lap)
    // Thuat toan: con cong khi so hang >= epsilon; dung khi so hang < epsilon
    //   (so hang < epsilon khong duoc cong vao tong)
    // Rang buoc: a > 0 (tranh chia cho 0 va so hang am), 0 < epsilon <= 0.1
    // ===================================================================
    static class TongPhanSoSaiSo
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 3: TONG PHAN SO (SAI SO) ---\n");

            double a = NhapLieu.NhapSoThuc("Moi ban nhap so a: ",
                x => x > 0, "a phai lon hon 0!");
            double epsilon = NhapLieu.NhapSoThuc("Moi ban nhap sai so epsilon (<=0.1): ",
                x => x > 0 && x <= 0.1, "epsilon phai thoa 0 < epsilon <= 0.1!");

            double s = 0;
            int n = 0;
            double soHang = 1.0 / a;
            while (soHang >= epsilon)
            {
                s += soHang;
                n++;
                soHang = 1.0 / (a + n);
            }

            Console.WriteLine($"Gia tri cua bieu thuc S(a = {a}, epsilon = {epsilon}) = {s:F4}.");
        }
    }
}
