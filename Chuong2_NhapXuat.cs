/*
 * ============================================================
 * CHƯƠNG 2: BÀI TẬP CƠ BẢN - NHẬP XUẤT DỮ LIỆU
 * ============================================================
  *Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Bài 1: In nhãn                          (InNhan)
 * Bài 2: Tính diện tích và chu hình tròn  (HinhTron)
 * Bài 3: Đổi sang giây                    (DoiSangGiay)
 * Bài 4: Đổi sang giờ phút giây           (DoiSangGioPhutGiay)
 * ============================================================
 * Cách chạy: dotnet run Chuong2_NhapXuat.cs
 * ============================================================
 */

// Khai báo sử dụng thư viện System
using System;

// Khai báo không gian tên
namespace LTCsharp.Buoi2
{
    // Khai báo lớp chính
    class Chuong2_NhapXuat
    {
        // ===================================================================
        // BÀI 1: IN NHÃN (InNhan)
        // -------------------------------------------------------------------
        // Đề bài: Viết chương trình in ra nhãn gồm nhiều dòng
        //         có viền bằng dấu * (asterisk)
        // ===================================================================
        static void InNhan()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 1: IN NHAN ---");

            // Xuống dòng để tạo khoảng cách
            Console.WriteLine();

            // In dòng viền trên: 30 dấu *
            // new string('*', 30) tạo chuỗi gồm 30 ký tự '*'
            Console.WriteLine(new string('*', 30));

            // In dòng thông tin trường học
            // PadRight(28) thêm khoảng trắng bên phải để chuỗi đủ 28 ký tự
            // Giúp căn chỉnh dấu * bên phải thẳng hàng
            Console.WriteLine("* {0} *", "Truong: Dai Hoc HUFLIT".PadRight(26));

            // In dòng thông tin khoa
            Console.WriteLine("* {0} *", "Khoa: CNTT".PadRight(26));

            // In dòng thông tin họ tên (để trống cho sinh viên tự điền)
            Console.WriteLine("* {0} *", "Ho ten:".PadRight(26));

            // In dòng viền dưới: 30 dấu *
            Console.WriteLine(new string('*', 30));
        }

        // ===================================================================
        // BÀI 2: TÍNH DIỆN TÍCH VÀ CHU VI HÌNH TRÒN (HinhTron)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào bán kính R. Tính diện tích S và chu vi P
        //         theo công thức: S = 3.14 * R² , P = 2 * 3.14 * R
        //         In kết quả với 1 số lẻ thập phân.
        // ===================================================================
        static void HinhTron()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 2: HINH TRON ---");

            // Khai báo hằng số PI = 3.14 (theo yêu cầu đề bài)
            // const = hằng số, không thể thay đổi giá trị sau khi khai báo
            const double PI = 3.14;

            // Khai báo biến bán kính R kiểu double (số thực)
            double R;

            // Khai báo biến diện tích S và chu vi P
            double S, P;

            // Nhập bán kính R từ bàn phím
            Console.Write("Nhap ban kinh R: ");
            R = double.Parse(Console.ReadLine());

            // Tính diện tích hình tròn: S = PI * R * R (tức PI * R²)
            S = PI * R * R;

            // Tính chu vi hình tròn: P = 2 * PI * R
            P = 2 * PI * R;

            // Xuất kết quả
            // F1 = định dạng số thực với 1 chữ số sau dấu phẩy thập phân
            // Ví dụ: R=5 → S=78.5, P=31.4
            Console.WriteLine("Dien tich S = {0:F1}", S);
            Console.WriteLine("Chu vi P = {0:F1}", P);
        }

        // ===================================================================
        // BÀI 3: ĐỔI SANG GIÂY (DoiSangGiay)
        // -------------------------------------------------------------------
        // Đề bài: Một thiết bị hoạt động được h giờ, m phút và s giây.
        //         Hãy viết chương trình chuyển thời gian đó sang tổng số giây.
        // Công thức: tongGiay = h * 3600 + m * 60 + s
        //   (1 giờ = 3600 giây, 1 phút = 60 giây)
        // ===================================================================
        static void DoiSangGiay()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 3: DOI SANG GIAY ---");

            // Khai báo 3 biến: giờ, phút, giây (kiểu int - số nguyên)
            int h, m, s;

            // Nhập số giờ
            Console.Write("Nhap so gio: ");
            h = int.Parse(Console.ReadLine());

            // Nhập số phút
            Console.Write("Nhap so phut: ");
            m = int.Parse(Console.ReadLine());

            // Nhập số giây
            Console.Write("Nhap so giay: ");
            s = int.Parse(Console.ReadLine());

            // Tính tổng số giây
            // 1 giờ = 60 phút = 60 * 60 giây = 3600 giây
            // 1 phút = 60 giây
            // Ví dụ: 1 giờ 20 phút 10 giây = 1*3600 + 20*60 + 10 = 4810 giây
            int tongGiay = h * 3600 + m * 60 + s;

            // Xuất kết quả ra màn hình
            // Ví dụ: "Tong so giay cua 1:20:10 la 4810 giay"
            Console.WriteLine("Tong so giay cua {0}:{1}:{2} la {3} giay",
                h, m, s, tongGiay);
        }

        // ===================================================================
        // BÀI 4: ĐỔI SANG GIỜ PHÚT GIÂY (DoiSangGioPhutGiay)
        // -------------------------------------------------------------------
        // Đề bài: Một thiết bị hoạt động được t giây.
        //         Hãy chuyển số giây đó dưới dạng số giờ, số phút, số giây.
        // Ý tưởng: Dùng phép chia nguyên (/) và phép chia dư (%)
        //   giờ  = t / 3600
        //   phút = (t % 3600) / 60
        //   giây = t % 60
        // ===================================================================
        static void DoiSangGioPhutGiay()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 4: DOI SANG GIO PHUT GIAY ---");

            // Khai báo biến tổng số giây nhập vào
            int t;

            // Nhập tổng số giây
            Console.Write("Nhap vao tong so giay: ");
            t = int.Parse(Console.ReadLine());

            // Tính số giờ: lấy phần nguyên khi chia cho 3600
            // Ví dụ: 4810 / 3600 = 1 (dư 1210)
            int gio = t / 3600;

            // Tính số phút: lấy phần dư khi chia 3600, rồi chia cho 60
            // t % 3600 = số giây còn lại sau khi trừ đi phần giờ
            // Ví dụ: 4810 % 3600 = 1210, rồi 1210 / 60 = 20 (phút)
            int phut = (t % 3600) / 60;

            // Tính số giây dư: lấy phần dư khi chia cho 60
            // Ví dụ: 4810 % 60 = 10 (giây)
            int giay = t % 60;

            // Xuất kết quả ra màn hình
            // Ví dụ: "4810 giay co dang 1:20:10"
            Console.WriteLine("{0} giay co dang {1}:{2}:{3}",
                t, gio, phut, giay);
        }

        // ===================================================================
        // HÀM MAIN - ĐIỂM BẮT ĐẦU CHƯƠNG TRÌNH
        // ===================================================================
        public static void Main(string[] args)
        {
            // Hiển thị tiêu đề chương
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 2: NHAP XUAT DU LIEU CO BAN       ");
            Console.WriteLine("============================================");

            // Hiển thị danh sách bài tập
            Console.WriteLine("1. In nhan                         (InNhan)");
            Console.WriteLine("2. Tinh dien tich va chu hinh tron (HinhTron)");
            Console.WriteLine("3. Doi sang giay                   (DoiSangGiay)");
            Console.WriteLine("4. Doi sang gio phut giay          (DoiSangGioPhutGiay)");
            Console.WriteLine("--------------------------------------------");

            // Nhập lựa chọn
            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine());

            // Xuống dòng
            Console.WriteLine();

            // Rẽ nhánh theo lựa chọn
            switch (chon)
            {
                case 1: InNhan(); break;
                case 2: HinhTron(); break;
                case 3: DoiSangGiay(); break;
                case 4: DoiSangGioPhutGiay(); break;
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
