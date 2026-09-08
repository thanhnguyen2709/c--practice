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
        static void TongDoan()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 1: TINH TONG DOAN ---");

            // Khai báo 2 biến kiểu int (số nguyên) để lưu giá trị a và b
            int a, b;

            // Hiển thị dòng nhắc nhập liệu (Write = không xuống dòng)
            Console.Write("Moi ban nhap so a, b: ");

            // Đọc một dòng văn bản từ bàn phím
            // Split(' ') tách chuỗi thành mảng chuỗi con dựa vào dấu cách
            // Ví dụ: "3 5" → ["3", "5"]
            string[] input = Console.ReadLine().Split(' ');

            // int.Parse() chuyển chuỗi "3" thành số nguyên 3
            // input[0] = phần tử đầu tiên của mảng → giá trị a
            a = int.Parse(input[0]);

            // input[1] = phần tử thứ hai của mảng → giá trị b
            b = int.Parse(input[1]);

            // Tính tổng đoạn [a, b] bằng công thức toán học:
            // Tổng(a→b) = Tổng(1→b) - Tổng(1→(a-1))
            // Trong đó: Tổng(1→n) = n * (n + 1) / 2

            // Tính tổng từ 1 đến b: b*(b+1)/2
            // Ép kiểu (long) để tránh tràn số khi b lớn
            long tongB = (long)b * (b + 1) / 2;

            // Tính tổng từ 1 đến (a-1): (a-1)*a/2
            long tongA1 = (long)(a - 1) * a / 2;

            // Tổng đoạn [a,b] = hiệu hai tổng trên
            long tong = tongB - tongA1;

            // Xuất kết quả ra màn hình
            // {0}, {1}, {2} là các vị trí sẽ được thay thế bởi a, b, tong
            Console.WriteLine("Tong cua cac so trong doan[{0}, {1}] la {2}.", a, b, tong);
        }

        // ===================================================================
        // BÀI 2: LŨY THỪA NHANH 1 (LuyThuaNhanh1)
        // -------------------------------------------------------------------
        // Đề bài: Cho số thực a. Hãy tính a², a⁵ và a¹⁷
        //         chỉ dùng 6 phép nhân.
        // Ý tưởng: Tận dụng kết quả trung gian để giảm số phép nhân
        //   a² = a * a              (phép nhân 1)
        //   a⁴ = a² * a²           (phép nhân 2)
        //   a⁵ = a⁴ * a            (phép nhân 3)
        //   a⁸ = a⁴ * a⁴           (phép nhân 4)
        //   a¹⁶ = a⁸ * a⁸          (phép nhân 5)
        //   a¹⁷ = a¹⁶ * a          (phép nhân 6)
        // ===================================================================
        static void LuyThuaNhanh1()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 2: LUY THUA NHANH 1 ---");

            // Khai báo biến a kiểu double (số thực, có phần thập phân)
            double a;

            // Hiển thị dòng nhắc nhập liệu
            Console.Write("Moi ban nhap so thuc a: ");

            // double.Parse() chuyển chuỗi nhập vào thành số thực
            a = double.Parse(Console.ReadLine());

            // --- Bắt đầu tính lũy thừa chỉ với 6 phép nhân ---

            // Phép nhân 1: tính a mũ 2 = a nhân a
            double a2 = a * a;

            // Phép nhân 2: tính a mũ 4 = a² nhân a² (tận dụng kết quả a²)
            double a4 = a2 * a2;

            // Phép nhân 3: tính a mũ 5 = a⁴ nhân a
            double a5 = a4 * a;

            // Phép nhân 4: tính a mũ 8 = a⁴ nhân a⁴
            double a8 = a4 * a4;

            // Phép nhân 5: tính a mũ 16 = a⁸ nhân a⁸
            double a16 = a8 * a8;

            // Phép nhân 6: tính a mũ 17 = a¹⁶ nhân a
            double a17 = a16 * a;

            // Xuất kết quả, F2 = định dạng số thực với 2 chữ số sau dấu phẩy
            // Ví dụ: a=2 → "2^2=4.00, 2^5=32.00, 2^17=131072.00"
            Console.WriteLine("Ket qua: {0}^2={1:F2}, {0}^5={2:F2}, {0}^17={3:F2}",
                a, a2, a5, a17);
        }

        // ===================================================================
        // BÀI 3: TÍNH BIỂU THỨC NHANH 1 (BieuThucNhanh1)
        // -------------------------------------------------------------------
        // Đề bài: Cho số thực x. Hãy tính giá trị biểu thức:
        //         f(x) = 1 + 2x + 3x² - 4x³
        //         chỉ dùng phép cộng, trừ, nhân
        //         sử dụng không quá 8 phép toán.
        // Ý tưởng: Dùng lược đồ Horner để giảm phép toán
        //   f(x) = 1 + x * (2 + x * (3 - 4 * x))
        //   Chỉ cần 3 phép nhân + 3 phép cộng/trừ = 6 phép toán
        // ===================================================================
        static void BieuThucNhanh1()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 3: TINH BIEU THUC NHANH 1 ---");

            // Khai báo biến x kiểu double (số thực)
            double x;

            // Nhập giá trị x từ bàn phím
            Console.Write("Moi ban nhap so thuc x: ");
            x = double.Parse(Console.ReadLine());

            // Tính f(x) = 1 + 2x + 3x² - 4x³ bằng lược đồ Horner
            // Biến đổi đại số:
            //   f(x) = 1 + 2x + 3x² - 4x³
            //        = 1 + x*(2 + 3x - 4x²)        ← rút x ra
            //        = 1 + x*(2 + x*(3 - 4x))       ← rút x ra lần nữa
            //
            // Phân tích từng phép toán:
            //   Bước 1: 4 * x          → phép nhân 1
            //   Bước 2: 3 - (4*x)      → phép trừ  1
            //   Bước 3: x * kết_quả    → phép nhân 2
            //   Bước 4: 2 + kết_quả    → phép cộng 1
            //   Bước 5: x * kết_quả    → phép nhân 3
            //   Bước 6: 1 + kết_quả    → phép cộng 2
            //   Tổng cộng: 6 phép toán (< 8) ✓
            double fx = 1 + x * (2 + x * (3 - 4 * x));

            // Xuất kết quả, F2 = 2 chữ số thập phân
            Console.WriteLine("f({0}) = {1:F2}", x, fx);
        }

        // ===================================================================
        // BÀI 4: TÌM QUÍ (TimQui)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào tháng. Hãy cho biết tháng đó thuộc quí nào?
        //         Tháng 1-3: Quí 1    Tháng 7-9:   Quí 3
        //         Tháng 4-6: Quí 2    Tháng 10-12: Quí 4
        // Ý tưởng: Dùng công thức: quí = (tháng - 1) / 3 + 1
        // ===================================================================
        static void TimQui()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 4: TIM QUI ---");

            // Khai báo biến tháng kiểu int
            int thang;

            // Nhập tháng từ bàn phím
            Console.Write("Moi ban nhap thang: ");
            thang = int.Parse(Console.ReadLine());

            // Kiểm tra tháng có hợp lệ không (1 đến 12)
            if (thang < 1 || thang > 12)
            {
                // Nếu tháng không hợp lệ, thông báo lỗi
                Console.WriteLine("Thang khong hop le! Vui long nhap tu 1 den 12.");
                return; // Thoát khỏi hàm, không thực hiện tiếp
            }

            // Tính quí bằng công thức toán học:
            // (tháng - 1) / 3  → chia nguyên cho 3
            //   Tháng 1: (1-1)/3 = 0/3 = 0   → 0 + 1 = Quí 1
            //   Tháng 2: (2-1)/3 = 1/3 = 0   → 0 + 1 = Quí 1
            //   Tháng 3: (3-1)/3 = 2/3 = 0   → 0 + 1 = Quí 1
            //   Tháng 4: (4-1)/3 = 3/3 = 1   → 1 + 1 = Quí 2
            //   Tháng 7: (7-1)/3 = 6/3 = 2   → 2 + 1 = Quí 3
            //   Tháng 10: (10-1)/3 = 9/3 = 3 → 3 + 1 = Quí 4
            int qui = (thang - 1) / 3 + 1;

            // Xuất kết quả ra màn hình
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
