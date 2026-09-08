/*
 * ============================================================
 * CHƯƠNG 1: BÀI TẬP CƠ BẢN - BIỂU THỨC
 * ============================================================
 *Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Bài 1: Tính tổng đoạn           (TongDoan)
 * Bài 2: Lũy thừa nhanh 1         (LuyThuaNhanh1)
 * Bài 3: Tính biểu thức nhanh 1   (BieuThucNhanh1)
 * Bài 4: Tìm quí                  (TimQui)
 * ============================================================
 * Cách chạy: dotnet run Chuong1_BieuThuc.cs
 * ============================================================
 */

// Khai báo sử dụng thư viện System - chứa các lớp cơ bản như Console, Math, ...
using System;

// Khai báo không gian tên (namespace) để tổ chức code
namespace LTCsharp.Buoi1
{
    // Khai báo lớp (class) chính chứa tất cả các bài tập
    class Chuong1_BieuThuc
    {
        // ===================================================================
        // BÀI 1: TÍNH TỔNG ĐOẠN (TongDoan)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào hai số nguyên a và b (a<=b).
        //         Hãy tính tổng các số nằm trong đoạn [a, b].
        //         Lưu ý: tổng từ a đến b = tổng(1→b) - tổng(1→a-1)
        //         Công thức tổng từ 1 đến n: n*(n+1)/2
        // ===================================================================

        // Hàm tính toán (public để TestChuong1 gọi được)
        // Nhận vào a, b → trả về tổng đoạn [a, b]
        public static long TinhTongDoan(int a, int b)
        {
            long tongB = (long)b * (b + 1) / 2;
            long tongA1 = (long)(a - 1) * a / 2;
            return tongB - tongA1;
        }

        // Hàm nhập/xuất (gọi hàm tính toán ở trên)
        static void TongDoan()
        {
            Console.WriteLine("--- BAI 1: TINH TONG DOAN ---");
            Console.Write("Moi ban nhap so a, b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            // Gọi hàm tính toán
            long tong = TinhTongDoan(a, b);

            Console.WriteLine("Tong cua cac so trong doan[{0}, {1}] la {2}.", a, b, tong);
        }

        // ===================================================================
        // BÀI 2: LŨY THỪA NHANH 1 (LuyThuaNhanh1)
        // -------------------------------------------------------------------
        // Đề bài: Cho số thực a. Hãy tính a², a⁵ và a¹⁷
        //         chỉ dùng 6 phép nhân.
        // ===================================================================

        // Hàm tính toán (public để TestChuong1 gọi được)
        // Nhận vào a → trả về mảng {a², a⁵, a¹⁷}
        public static double[] TinhLuyThua(double a)
        {
            double a2 = a * a;           // Phép nhân 1
            double a4 = a2 * a2;         // Phép nhân 2
            double a5 = a4 * a;          // Phép nhân 3
            double a8 = a4 * a4;         // Phép nhân 4
            double a16 = a8 * a8;        // Phép nhân 5
            double a17 = a16 * a;        // Phép nhân 6
            return new double[] { a2, a5, a17 };
        }

        // Hàm nhập/xuất
        static void LuyThuaNhanh1()
        {
            Console.WriteLine("--- BAI 2: LUY THUA NHANH 1 ---");
            Console.Write("Moi ban nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());

            // Gọi hàm tính toán
            double[] kq = TinhLuyThua(a);

            Console.WriteLine("Ket qua: {0}^2={1:F2}, {0}^5={2:F2}, {0}^17={3:F2}",
                a, kq[0], kq[1], kq[2]);
        }

        // ===================================================================
        // BÀI 3: TÍNH BIỂU THỨC NHANH 1 (BieuThucNhanh1)
        // -------------------------------------------------------------------
        // Đề bài: f(x) = 1 + 2x + 3x² - 4x³
        // Dùng lược đồ Horner: f(x) = 1 + x*(2 + x*(3 - 4*x))
        // ===================================================================

        // Hàm tính toán (public để TestChuong1 gọi được)
        // Nhận vào x → trả về f(x)
        public static double TinhBieuThuc(double x)
        {
            return 1 + x * (2 + x * (3 - 4 * x));
        }

        // Hàm nhập/xuất
        static void BieuThucNhanh1()
        {
            Console.WriteLine("--- BAI 3: TINH BIEU THUC NHANH 1 ---");
            Console.Write("Moi ban nhap so thuc x: ");
            double x = double.Parse(Console.ReadLine());

            // Gọi hàm tính toán
            double fx = TinhBieuThuc(x);

            Console.WriteLine("f({0}) = {1:F2}", x, fx);
        }

        // ===================================================================
        // BÀI 4: TÌM QUÍ (TimQui)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào tháng → cho biết thuộc quí nào?
        // Công thức: quí = (tháng - 1) / 3 + 1
        // ===================================================================

        // Hàm tính toán (public để TestChuong1 gọi được)
        // Nhận vào tháng → trả về số quí (1-4), trả -1 nếu không hợp lệ
        public static int TinhQui(int thang)
        {
            if (thang < 1 || thang > 12) return -1;
            return (thang - 1) / 3 + 1;
        }

        // Hàm nhập/xuất
        static void TimQui()
        {
            Console.WriteLine("--- BAI 4: TIM QUI ---");
            Console.Write("Moi ban nhap thang: ");
            int thang = int.Parse(Console.ReadLine());

            // Gọi hàm tính toán
            int qui = TinhQui(thang);

            if (qui == -1)
                Console.WriteLine("Thang khong hop le! Vui long nhap tu 1 den 12.");
            else
                Console.WriteLine("Thang {0} thuoc qui {1}.", thang, qui);
        }


        // ===================================================================
        // HÀM MAIN - ĐIỂM BẮT ĐẦU CHƯƠNG TRÌNH
        // -------------------------------------------------------------------
        // Khi chạy chương trình, hàm Main() sẽ được gọi đầu tiên.
        // Hiển thị menu để người dùng chọn bài tập muốn chạy.
        // ===================================================================
        public static void Main(string[] args)
        {
            // Hiển thị tiêu đề chương
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 1: BAI TAP CO BAN - BIEU THUC     ");
            Console.WriteLine("============================================");

            // Hiển thị danh sách bài tập
            Console.WriteLine("1. Tinh tong doan          (TongDoan)");
            Console.WriteLine("2. Luy thua nhanh 1        (LuyThuaNhanh1)");
            Console.WriteLine("3. Tinh bieu thuc nhanh 1  (BieuThucNhanh1)");
            Console.WriteLine("4. Tim qui                 (TimQui)");
            Console.WriteLine("--------------------------------------------");

            // Nhập lựa chọn của người dùng
            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine());

            // Xuống dòng cho dễ đọc
            Console.WriteLine();

            // switch-case: rẽ nhánh theo giá trị của biến 'chon'
            switch (chon)
            {
                case 1:                          // Nếu chon == 1
                    TongDoan();                  // → gọi hàm TongDoan()
                    break;                       // → thoát khỏi switch
                case 2:                          // Nếu chon == 2
                    LuyThuaNhanh1();             // → gọi hàm LuyThuaNhanh1()
                    break;
                case 3:                          // Nếu chon == 3
                    BieuThucNhanh1();            // → gọi hàm BieuThucNhanh1()
                    break;
                case 4:                          // Nếu chon == 4
                    TimQui();                    // → gọi hàm TimQui()
                    break;
                default:                         // Nếu không thuộc các case trên
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            // Dừng màn hình chờ nhấn phím trước khi đóng
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.Read();
        }
    }
}
