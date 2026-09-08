/*
 * ============================================================
 * CHƯƠNG 3: CẤU TRÚC RẼ NHÁNH
 * ============================================================
  *Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Bài 1: Tìm Max Min 5 số          (MaxMin5So)
 * Bài 2: Tính giá trị hàm số 1     (GiaTriHamSo1)
 * Bài 3: Giải phương trình bậc 2   (PhuongTrinhBac2)
 * Bài 4: Đọc tháng tiếng Anh       (ThangTiengAnh)
 * ============================================================
 * Cách chạy: dotnet run Chuong3_ReNhanh.cs
 * ============================================================
 */

// Khai báo sử dụng thư viện System
using System;

// Khai báo không gian tên
namespace LTCsharp.Buoi3
{
    // Khai báo lớp chính
    class Chuong3_ReNhanh
    {
        // ===================================================================
        // BÀI 1: TÌM GIÁ TRỊ LỚN NHẤT, NHỎ NHẤT CỦA 5 SỐ (MaxMin5So)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào giá trị a, b, c, d, e.
        //         Hãy tìm giá trị lớn nhất và nhỏ nhất của 5 số đó.
        // Ý tưởng: Giả sử max = a (số đầu tiên),
        //          so sánh lần lượt với b, c, d, e
        //          nếu số nào lớn hơn max → cập nhật max
        //          Tương tự cho min
        // ===================================================================
        static void MaxMin5So()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 1: TIM MAX MIN 5 SO ---");

            // Khai báo 5 biến kiểu double để lưu 5 số thực
            double a, b, c, d, e;

            // Nhập 5 số trên cùng một dòng, cách nhau bằng dấu cách
            Console.Write("Moi ban nhap 5 so a, b, c, d, e: ");

            // Đọc dòng nhập và tách thành mảng chuỗi
            string[] input = Console.ReadLine().Split(' ');

            // Chuyển từng phần tử chuỗi thành số thực
            a = double.Parse(input[0]); // Số thứ 1
            b = double.Parse(input[1]); // Số thứ 2
            c = double.Parse(input[2]); // Số thứ 3
            d = double.Parse(input[3]); // Số thứ 4
            e = double.Parse(input[4]); // Số thứ 5

            // --- Tìm giá trị lớn nhất (max) ---

            // Bước 1: Giả sử max = a (lấy số đầu tiên làm giá trị ban đầu)
            double max = a;

            // Bước 2: So sánh max với b, nếu b > max thì cập nhật max = b
            if (b > max) max = b;

            // Bước 3: So sánh max với c
            if (c > max) max = c;

            // Bước 4: So sánh max với d
            if (d > max) max = d;

            // Bước 5: So sánh max với e
            if (e > max) max = e;

            // --- Tìm giá trị nhỏ nhất (min) ---

            // Tương tự, giả sử min = a
            double min = a;

            // So sánh lần lượt với b, c, d, e
            if (b < min) min = b; // Nếu b < min → cập nhật min = b
            if (c < min) min = c; // Nếu c < min → cập nhật min = c
            if (d < min) min = d; // Nếu d < min → cập nhật min = d
            if (e < min) min = e; // Nếu e < min → cập nhật min = e

            // Xuất kết quả
            Console.WriteLine("Gia tri lon nhat cua {0}, {1}, {2}, {3}, {4} la {5}.",
                a, b, c, d, e, max);
            Console.WriteLine("Gia tri nho nhat cua {0}, {1}, {2}, {3}, {4} la {5}.",
                a, b, c, d, e, min);
        }

        // ===================================================================
        // BÀI 2: TÍNH GIÁ TRỊ HÀM SỐ 1 (GiaTriHamSo1)
        // -------------------------------------------------------------------
        // Đề bài: Cho số thực x. Tính giá trị f1(x) và f2(x):
        //
        //         f1(x) = | 0       nếu x <= 0
        //                 | x       nếu 0 < x <= 1
        //                 | x⁴      nếu x > 1
        //
        //         f2(x) = | x² + 4x + 5        nếu x <= 2
        //                 | 1 / (x² + 4x + 5)  nếu x > 2
        // ===================================================================
        static void GiaTriHamSo1()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 2: TINH GIA TRI HAM SO 1 ---");

            // Khai báo biến x kiểu double
            double x;

            // Nhập giá trị x
            Console.Write("Moi ban nhap so thuc x: ");
            x = double.Parse(Console.ReadLine());

            // --- Tính f1(x) ---
            // Khai báo biến f1 để lưu kết quả
            double f1;

            // Dùng cấu trúc if-else if-else để xét từng trường hợp
            if (x <= 0)
            {
                // Trường hợp 1: x <= 0 → f1(x) = 0
                f1 = 0;
            }
            else if (x <= 1)
            {
                // Trường hợp 2: 0 < x <= 1 → f1(x) = x
                // (vì đã loại trường hợp x <= 0 ở trên, nên ở đây x > 0)
                f1 = x;
            }
            else
            {
                // Trường hợp 3: x > 1 → f1(x) = x⁴
                // Tính x⁴ = x * x * x * x (hoặc dùng Math.Pow(x, 4))
                f1 = x * x * x * x;
            }

            // --- Tính f2(x) ---
            double f2;

            // Tính biểu thức chung: x² + 4x + 5 (dùng lại cho cả 2 trường hợp)
            double bieuThuc = x * x + 4 * x + 5;

            if (x <= 2)
            {
                // Trường hợp 1: x <= 2 → f2(x) = x² + 4x + 5
                f2 = bieuThuc;
            }
            else
            {
                // Trường hợp 2: x > 2 → f2(x) = 1 / (x² + 4x + 5)
                f2 = 1.0 / bieuThuc;
            }

            // Xuất kết quả, F2 = 2 chữ số thập phân
            Console.WriteLine("f1({0}) = {1:F2}", x, f1);
            Console.WriteLine("f2({0}) = {1:F2}", x, f2);
        }

        // ===================================================================
        // BÀI 3: GIẢI PHƯƠNG TRÌNH BẬC 2 (PhuongTrinhBac2)
        // -------------------------------------------------------------------
        // Đề bài: Nhập 3 số thực a, b, c.
        //         Hãy tìm nghiệm của phương trình bậc 2: ax² + bx + c = 0
        //
        // Công thức:
        //   Delta = b² - 4ac
        //   - Nếu Delta < 0  → phương trình vô nghiệm
        //   - Nếu Delta = 0  → nghiệm kép x = -b / (2a)
        //   - Nếu Delta > 0  → 2 nghiệm:
        //       x1 = (-b + √Delta) / (2a)
        //       x2 = (-b - √Delta) / (2a)
        // ===================================================================
        static void PhuongTrinhBac2()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 3: GIAI PHUONG TRINH BAC 2 ---");

            // Khai báo 3 hệ số a, b, c kiểu double
            double a, b, c;

            // Nhập 3 hệ số trên cùng một dòng
            Console.Write("Moi ban nhap he so a, b, c: ");
            string[] input = Console.ReadLine().Split(' ');

            // Chuyển chuỗi thành số thực
            a = double.Parse(input[0]); // Hệ số a (bậc 2)
            b = double.Parse(input[1]); // Hệ số b (bậc 1)
            c = double.Parse(input[2]); // Hệ số c (hằng số)

            // Kiểm tra a == 0 → không phải phương trình bậc 2
            if (a == 0)
            {
                // Nếu a = 0 → phương trình bậc nhất: bx + c = 0
                Console.WriteLine("Day khong phai phuong trinh bac 2 (a = 0).");

                // Kiểm tra thêm: nếu b cũng bằng 0
                if (b == 0)
                {
                    // 0x + c = 0 → vô nghiệm hoặc vô số nghiệm
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    // bx + c = 0 → x = -c/b
                    Console.WriteLine("Phuong trinh bac nhat co nghiem x = {0:F2}", -c / b);
                }
                return; // Thoát hàm
            }

            // Tính Delta (biệt thức) = b² - 4*a*c
            double delta = b * b - 4 * a * c;

            // In thông tin phương trình
            Console.Write("Phuong trinh bac 2 {0}x^2 + {1}x + {2} = 0 co: ", a, b, c);

            // Xét 3 trường hợp dựa vào giá trị Delta
            if (delta < 0)
            {
                // Delta < 0: phương trình vô nghiệm (không có nghiệm thực)
                Console.WriteLine("vo nghiem (Delta = {0:F2} < 0).", delta);
            }
            else if (delta == 0)
            {
                // Delta = 0: phương trình có nghiệm kép
                // x = -b / (2*a)
                double x = -b / (2 * a);
                Console.WriteLine("1 nghiem kep, x = {0:F2}.", x);
            }
            else
            {
                // Delta > 0: phương trình có 2 nghiệm phân biệt
                // Math.Sqrt() = hàm tính căn bậc 2 (square root)
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a); // Nghiệm 1
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a); // Nghiệm 2
                Console.WriteLine("2 nghiem, x1 = {0:F2}, x2 = {1:F2}.", x1, x2);
            }
        }

        // ===================================================================
        // BÀI 4: ĐỌC THÁNG TIẾNG ANH (ThangTiengAnh)
        // -------------------------------------------------------------------
        // Đề bài: Viết chương trình nhập vào tháng từ 1 đến 12.
        //         Cho biết tên gọi tiếng Anh của tháng vừa nhập.
        // Ý tưởng: Dùng switch-case để ánh xạ số → tên tháng
        // ===================================================================
        static void ThangTiengAnh()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 4: DOC THANG TIENG ANH ---");

            // Khai báo biến tháng
            int thang;

            // Nhập tháng
            Console.Write("Moi ban nhap vao thang: ");
            thang = int.Parse(Console.ReadLine());

            // Khai báo biến chuỗi để lưu tên tháng tiếng Anh
            string tenThang;

            // Dùng switch-case để chuyển số tháng → tên tiếng Anh
            switch (thang)
            {
                case 1:  tenThang = "January";   break; // Tháng 1
                case 2:  tenThang = "February";  break; // Tháng 2
                case 3:  tenThang = "March";     break; // Tháng 3
                case 4:  tenThang = "April";     break; // Tháng 4
                case 5:  tenThang = "May";       break; // Tháng 5
                case 6:  tenThang = "June";      break; // Tháng 6
                case 7:  tenThang = "July";      break; // Tháng 7
                case 8:  tenThang = "August";    break; // Tháng 8
                case 9:  tenThang = "September"; break; // Tháng 9
                case 10: tenThang = "October";   break; // Tháng 10
                case 11: tenThang = "November";  break; // Tháng 11
                case 12: tenThang = "December";  break; // Tháng 12
                default:
                    // Nếu tháng không nằm trong 1-12 → không hợp lệ
                    tenThang = "Khong hop le";
                    break;
            }

            // Xuất kết quả
            // Ví dụ: "Tieng anh cua thang 5 la May."
            Console.WriteLine("Tieng anh cua thang {0} la {1}.", thang, tenThang);
        }

        // ===================================================================
        // HÀM MAIN - ĐIỂM BẮT ĐẦU CHƯƠNG TRÌNH
        // ===================================================================
        public static void Main(string[] args)
        {
            // Hiển thị tiêu đề
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 3: CAU TRUC RE NHANH              ");
            Console.WriteLine("============================================");

            // Hiển thị menu
            Console.WriteLine("1. Tim Max Min 5 so          (MaxMin5So)");
            Console.WriteLine("2. Tinh gia tri ham so 1     (GiaTriHamSo1)");
            Console.WriteLine("3. Giai phuong trinh bac 2   (PhuongTrinhBac2)");
            Console.WriteLine("4. Doc thang tieng Anh       (ThangTiengAnh)");
            Console.WriteLine("--------------------------------------------");

            // Nhập lựa chọn
            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Rẽ nhánh theo lựa chọn
            switch (chon)
            {
                case 1: MaxMin5So(); break;
                case 2: GiaTriHamSo1(); break;
                case 3: PhuongTrinhBac2(); break;
                case 4: ThangTiengAnh(); break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            // Dừng màn hình
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.Read();
        }
    }
}
