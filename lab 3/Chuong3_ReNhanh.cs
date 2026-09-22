using System;

namespace LTCsharp.Chuong3
{
    class Chuong3_ReNhanh
    {
        // ===================================================================
        // BAI 1: TIM MAX MIN TRONG 5 SO
        // Kien thuc: Cau lenh if lien tuc, so sanh tuan tu
        // Thuat toan: Gan max=min=a, duyet tung bien cap nhat max/min
        // LinQPad: double max=1, min=1;
        //          foreach(var x in new[]{5,6,2,8}) { if(x>max)max=x; if(x<min)min=x; }
        //          $"Max={max}, Min={min}".Dump(); // => "Max=8, Min=1"
        // ===================================================================
        static void MaxMin5So()
        {
            Console.WriteLine("--- BAI 1: TIM MAX MIN 5 SO ---\n");

            Console.Write("Nhap so thu 1 (a): ");
            double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so thu 2 (b): ");
            double b = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so thu 3 (c): ");
            double c = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so thu 4 (d): ");
            double d = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so thu 5 (e): ");
            double e = double.Parse(Console.ReadLine() ?? "0");

            // Khoi tao max va min bang gia tri dau tien
            double max = a, min = a;

            // So sanh tuan tu tung bien voi max va min
            // Dung if (khong phai else if) vi can kiem tra ca max VA min
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;

            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;

            Console.WriteLine("\nKet qua:");
            Console.WriteLine("  Max cua ({0}, {1}, {2}, {3}, {4}) = {5}", a, b, c, d, e, max);
            Console.WriteLine("  Min cua ({0}, {1}, {2}, {3}, {4}) = {5}", a, b, c, d, e, min);
        }

        // ===================================================================
        // BAI 2: TINH GIA TRI HAM SO THEO DIEU KIEN
        // Kien thuc: if - else if - else (re nhanh nhieu nhanh)
        //
        // Ham f1(x):
        //   x <= 0      -> f1 = 0
        //   0 < x <= 1  -> f1 = x
        //   x > 1       -> f1 = x^4
        //
        // Ham f2(x):
        //   x <= 2      -> f2 = x^2 + 4x + 5
        //   x > 2       -> f2 = 1 / (x^2 + 4x + 5)
        //
        // LinQPad: TinhF1(3).Dump("f1(3)");  // => 81
        //          TinhF2(0).Dump("f2(0)");  // => 5
        // ===================================================================

        // Tinh f1(x) theo dieu kien re nhanh
        static double TinhF1(double x)
        {
            if (x <= 0)
                return 0;             // Nhanh 1: x <= 0
            else if (x <= 1)
                return x;             // Nhanh 2: 0 < x <= 1
            else
                return x * x * x * x; // Nhanh 3: x > 1 -> x^4
        }

        // Tinh f2(x) theo dieu kien re nhanh
        static double TinhF2(double x)
        {
            // Bieu thuc chung: x^2 + 4x + 5
            double bt = x * x + 4 * x + 5;

            if (x <= 2)
                return bt;        // Nhanh 1: x <= 2
            else
                return 1.0 / bt;  // Nhanh 2: x > 2 -> nghich dao
        }

        static void GiaTriHamSo1()
        {
            Console.WriteLine("--- BAI 2: TINH GIA TRI HAM SO ---\n");

            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine() ?? "0");

            double f1 = TinhF1(x);
            double f2 = TinhF2(x);

            Console.WriteLine("\nKet qua:");
            Console.WriteLine("  f1({0}) = {1}", x, f1);
            Console.WriteLine("  f2({0}) = {1}", x, f2);
        }

        // ===================================================================
        // BAI 3: GIAI PHUONG TRINH BAC 2 (ax^2 + bx + c = 0)
        // Kien thuc: if - else if - else, Math.Sqrt()
        //
        // Cong thuc:
        //   Delta = b^2 - 4ac
        //   Delta > 0  -> 2 nghiem: x1 = (-b + sqrt(Delta)) / 2a
        //                            x2 = (-b - sqrt(Delta)) / 2a
        //   Delta = 0  -> nghiem kep: x = -b / 2a
        //   Delta < 0  -> vo nghiem thuc
        //
        // LinQPad: double a=1, b=5, c=6, delta=b*b-4*a*c;
        //          delta.Dump("Delta");
        //          ((-b+Math.Sqrt(delta))/(2*a)).Dump("x1"); // => -2
        // ===================================================================
        static void PhuongTrinhBac2()
        {
            Console.WriteLine("--- BAI 3: GIAI PHUONG TRINH BAC 2 ---\n");
            Console.WriteLine("  Dang: ax^2 + bx + c = 0\n");

            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("\nPhuong trinh: {0}x^2 + {1}x + {2} = 0", a, b, c);

            // Truong hop a = 0 -> khong phai PT bac 2
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("  => Vo so nghiem (0 = 0)");
                    else
                        Console.WriteLine("  => Vo nghiem ({0} != 0)", c);
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("  => PT bac 1, nghiem x = {0}", x);
                }
            }
            else
            {
                // Tinh Delta
                double delta = b * b - 4 * a * c;
                Console.WriteLine("  Delta = {0}", delta);

                if (delta > 0)
                {
                    // 2 nghiem phan biet
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("  => Hai nghiem phan biet:");
                    Console.WriteLine("     x1 = {0}", x1);
                    Console.WriteLine("     x2 = {0}", x2);
                }
                else if (delta == 0)
                {
                    // Nghiem kep
                    double x = -b / (2 * a);
                    Console.WriteLine("  => Nghiem kep: x = {0}", x);
                }
                else
                {
                    Console.WriteLine("  => Vo nghiem thuc (Delta < 0)");
                }
            }
        }

        // ===================================================================
        // BAI 4: DOC THANG BANG TIENG ANH
        // Kien thuc: switch-case
        // Ghi chu: switch-case phu hop khi so sanh 1 bien voi nhieu gia tri
        //          co dinh (1-12). Dung return thi khong can break.
        //
        // LinQPad: int thang = 9;
        //          string[] t = {"","January","February","March","April",
        //            "May","June","July","August","September",
        //            "October","November","December"};
        //          t[thang].Dump(); // => "September"
        // ===================================================================

        // Tra ve ten thang tieng Anh tu so thang (1-12)
        static string DocThangTiengAnh(int thang)
        {
            switch (thang)
            {
                case 1:  return "January";
                case 2:  return "February";
                case 3:  return "March";
                case 4:  return "April";
                case 5:  return "May";
                case 6:  return "June";
                case 7:  return "July";
                case 8:  return "August";
                case 9:  return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Khong hop le";
            }
        }

        static void ThangTiengAnh()
        {
            Console.WriteLine("--- BAI 4: DOC THANG TIENG ANH ---\n");

            Console.Write("Nhap thang (1-12): ");
            int thang = int.Parse(Console.ReadLine() ?? "1");

            string tenThang = DocThangTiengAnh(thang);
            Console.WriteLine("  Thang {0} tieng Anh la: {1}", thang, tenThang);
        }

        // ===================================================================
        // HAM MAIN: Menu chon bai tap
        // ===================================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 3: CAU TRUC RE NHANH              ");
            Console.WriteLine("============================================");

            Console.WriteLine("1. Tim Max Min 5 so          (MaxMin5So)");
            Console.WriteLine("2. Tinh gia tri ham so 1     (GiaTriHamSo1)");
            Console.WriteLine("3. Giai phuong trinh bac 2   (PhuongTrinhBac2)");
            Console.WriteLine("4. Doc thang tieng Anh       (ThangTiengAnh)");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine();

            switch (chon)
            {
                case 1: MaxMin5So(); break;
                case 2: GiaTriHamSo1(); break;
                case 3: PhuongTrinhBac2(); break;
                case 4: ThangTiengAnh(); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.Read();
        }
    }
}