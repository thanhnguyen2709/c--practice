/*
 * ============================================================
 * CHƯƠNG 4: CÂU LỆNH CHỌN LỰA
 * ============================================================
  *Tác giả : Nguyễn Trường Thành
 * Ngày viết: 8/9/2026
 * Bài 1: Điểm trung bình       (DiemTrungBinh)
 * Bài 2: Tính tiền nước         (TienNuoc)
 * Bài 3: Ngày sau               (NgaySau)
 * Bài 4: Phân loại tam giác     (PhanLoaiTamGiac)
 * ============================================================
 * Cách chạy: dotnet run Chuong4_CauLenhChonLua.cs
 * ============================================================
 */

// Khai báo sử dụng thư viện System
using System;

// Khai báo không gian tên
namespace NMLT.Chuong4
{
    // Khai báo lớp chính
    class Chuong4_CauLenhChonLua
    {
        // ===================================================================
        // BÀI 1: ĐIỂM TRUNG BÌNH (DiemTrungBinh)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào 3 điểm: Toán, Lý, Hóa.
        //         Tính điểm trung bình và phân loại học sinh.
        //
        // Công thức: DTB = (Toán * 2 + Lý * 3 + Hóa) / 6
        //
        // Tiêu chuẩn xếp loại:
        //   8  <= DTB <= 10   → "Gioi"
        //   6.5 <= DTB < 8    → "Kha"
        //   5  <= DTB < 6.5   → "Trung binh"
        //   DTB < 5           → "Yeu"
        // ===================================================================
        static void DiemTrungBinh()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 1: DIEM TRUNG BINH ---");

            // Khai báo 3 biến lưu điểm Toán, Lý, Hóa (kiểu double - số thực)
            double toan, ly, hoa;

            // Nhập 3 điểm trên cùng một dòng, cách nhau bằng dấu cách
            Console.Write("Moi ban nhap diem toan, ly, hoa: ");
            string[] input = Console.ReadLine().Split(' ');

            // Chuyển chuỗi thành số thực và gán cho từng biến
            toan = double.Parse(input[0]); // Điểm Toán
            ly   = double.Parse(input[1]); // Điểm Lý
            hoa  = double.Parse(input[2]); // Điểm Hóa

            // Tính điểm trung bình theo công thức:
            // DTB = (Toán * 2 + Lý * 3 + Hóa) / 6
            // Toán nhân hệ số 2, Lý nhân hệ số 3, Hóa hệ số 1
            // Tổng hệ số = 2 + 3 + 1 = 6
            double dtb = (toan * 2 + ly * 3 + hoa) / 6;

            // Khai báo biến xếp loại
            string xepLoai;

            // Phân loại dựa trên DTB bằng cấu trúc if-else if
            if (dtb >= 8)
            {
                // DTB từ 8 trở lên → xếp loại Giỏi
                xepLoai = "Gioi";
            }
            else if (dtb >= 6.5)
            {
                // DTB từ 6.5 đến dưới 8 → xếp loại Khá
                xepLoai = "Kha";
            }
            else if (dtb >= 5)
            {
                // DTB từ 5 đến dưới 6.5 → xếp loại Trung bình
                xepLoai = "Trung binh";
            }
            else
            {
                // DTB dưới 5 → xếp loại Yếu
                xepLoai = "Yeu";
            }

            // Xuất kết quả
            // F2 = 2 chữ số thập phân
            Console.WriteLine("Ban co diem trung binh {0:F2} duoc xep loai {1}.",
                dtb, xepLoai);
        }

        // ===================================================================
        // BÀI 2: TÍNH TIỀN NƯỚC TIÊU THỤ (TienNuoc)
        // -------------------------------------------------------------------
        // Đề bài: Nhập chỉ số nước cũ, mới và số người trong hộ.
        //         Tính tiền nước dựa trên bảng giá định mức (người/tháng):
        //
        //         | Định mức           | Giá (đ/m³) |
        //         |---------------------|------------|
        //         | 4 m³ đầu tiên      | 4.400      |
        //         | 2 m³ kế tiếp       | 8.300      |
        //         | Những m³ tiếp theo  | 10.500     |
        //
        //         Cộng thêm: thuế VAT 5% + phí bảo vệ môi trường 10%
        // ===================================================================
        static void TienNuoc()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 2: TINH TIEN NUOC ---");

            // Khai báo biến: chỉ số cũ, chỉ số mới, số người
            int chiSoCu, chiSoMoi, soNguoi;

            // Nhập chỉ số nước tháng trước (chỉ số cũ trên đồng hồ nước)
            Console.Write("Moi ban nhap chi so tieu thu nuoc thang truoc (m^3): ");
            chiSoCu = int.Parse(Console.ReadLine());

            // Nhập chỉ số nước tháng này (chỉ số mới trên đồng hồ nước)
            Console.Write("Moi ban nhap chi so tieu thu nuoc trong thang (m^3): ");
            chiSoMoi = int.Parse(Console.ReadLine());

            // Nhập số người đăng ký trong hộ gia đình
            Console.Write("Nhap so nguoi trong ho: ");
            soNguoi = int.Parse(Console.ReadLine());

            // Tính lượng nước tiêu thụ trong tháng (m³)
            // = chỉ số mới - chỉ số cũ
            int luongNuoc = chiSoMoi - chiSoCu;

            // Tính định mức theo số người:
            // - Mức 1: mỗi người được 4 m³ đầu tiên giá rẻ
            // - Mức 2: mỗi người thêm 2 m³ kế tiếp giá trung bình
            // - Mức 3: phần còn lại giá cao nhất
            int mucRe = 4 * soNguoi;       // Tổng m³ ở mức giá rẻ (4 m³/người)
            int mucTrung = 2 * soNguoi;    // Tổng m³ ở mức giá trung bình (2 m³/người)

            // Khai báo biến lưu tổng tiền nước
            double tienNuoc = 0;

            // Biến tạm lưu lượng nước còn lại cần tính giá
            int conLai = luongNuoc;

            // --- Tính tiền theo từng mức giá ---

            // Mức 1: 4 m³ đầu tiên/người × 4.400 đ/m³
            if (conLai > 0)
            {
                // Math.Min(conLai, mucRe) = lấy giá trị nhỏ hơn
                // Nếu conLai <= mucRe → tính hết conLai ở mức 1
                // Nếu conLai > mucRe  → chỉ tính mucRe m³ ở mức 1
                int m3Muc1 = Math.Min(conLai, mucRe);

                // Cộng tiền mức 1 vào tổng
                tienNuoc += m3Muc1 * 4400;

                // Trừ đi số m³ đã tính
                conLai -= m3Muc1;
            }

            // Mức 2: 2 m³ kế tiếp/người × 8.300 đ/m³
            if (conLai > 0)
            {
                // Tương tự, lấy min giữa số còn lại và định mức mức 2
                int m3Muc2 = Math.Min(conLai, mucTrung);

                // Cộng tiền mức 2
                tienNuoc += m3Muc2 * 8300;

                // Trừ đi
                conLai -= m3Muc2;
            }

            // Mức 3: Phần còn lại × 10.500 đ/m³
            if (conLai > 0)
            {
                // Tất cả m³ còn lại tính theo giá cao nhất
                tienNuoc += conLai * 10500;
            }

            // Tính thuế VAT 5% trên tổng tiền nước
            double thueVAT = tienNuoc * 0.05;

            // Tính phí bảo vệ môi trường 10% trên tổng tiền nước
            double phiMoiTruong = tienNuoc * 0.10;

            // Tổng tiền phải trả = tiền nước + thuế + phí
            double tongTien = tienNuoc + thueVAT + phiMoiTruong;

            // Xuất kết quả
            // N0 = định dạng số với dấu phân cách hàng nghìn (1,000)
            Console.WriteLine("So tien phai tra cho {0} m^3 tieu thu trong thang la {1:N0} D.",
                luongNuoc, tongTien);
        }

        // ===================================================================
        // BÀI 3: NGÀY SAU (NgaySau)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào ngày, tháng, năm.
        //         Hỏi ngày sau đó là ngày nào?
        //
        // Ý tưởng:
        //   1. Xác định số ngày tối đa của tháng hiện tại
        //   2. Nếu ngày hiện tại < max → ngày + 1
        //   3. Nếu ngày hiện tại = max → chuyển sang tháng mới (ngày 1)
        //   4. Nếu tháng = 12 → chuyển sang năm mới (1/1/năm+1)
        //   5. Tháng 2: kiểm tra năm nhuận (28 hoặc 29 ngày)
        //
        // Năm nhuận: chia hết cho 4 VÀ (không chia hết 100 HOẶC chia hết 400)
        // ===================================================================
        static void NgaySau()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 3: NGAY SAU ---");

            // Khai báo biến ngày, tháng, năm
            int ngay, thang, nam;

            // Nhập ngày, tháng, năm trên cùng một dòng
            Console.Write("Moi ban nhap ngay, thang, nam: ");
            string[] input = Console.ReadLine().Split(' ');

            // Chuyển chuỗi thành số nguyên
            ngay  = int.Parse(input[0]); // Ngày
            thang = int.Parse(input[1]); // Tháng
            nam   = int.Parse(input[2]); // Năm

            // Lưu lại ngày gốc để in kết quả so sánh
            int ngayGoc = ngay, thangGoc = thang, namGoc = nam;

            // --- Xác định số ngày tối đa của tháng hiện tại ---
            int soNgayMax;

            // Dùng switch-case để xét từng tháng
            switch (thang)
            {
                // Các tháng có 31 ngày: 1, 3, 5, 7, 8, 10, 12
                case 1: case 3: case 5: case 7:
                case 8: case 10: case 12:
                    soNgayMax = 31;
                    break;

                // Các tháng có 30 ngày: 4, 6, 9, 11
                case 4: case 6: case 9: case 11:
                    soNgayMax = 30;
                    break;

                // Tháng 2: kiểm tra năm nhuận
                case 2:
                    // Năm nhuận khi:
                    // - Chia hết cho 400, HOẶC
                    // - Chia hết cho 4 VÀ không chia hết cho 100
                    // Ví dụ: 2000 (nhuận), 1900 (không), 2024 (nhuận)
                    bool namNhuan = (nam % 400 == 0) ||
                                    (nam % 4 == 0 && nam % 100 != 0);

                    // Nếu năm nhuận → tháng 2 có 29 ngày, ngược lại 28 ngày
                    soNgayMax = namNhuan ? 29 : 28;
                    break;

                default:
                    // Tháng không hợp lệ
                    soNgayMax = 30;
                    break;
            }

            // --- Tính ngày tiếp theo ---
            if (ngay < soNgayMax)
            {
                // Trường hợp 1: Chưa hết tháng → chỉ cần tăng ngày lên 1
                ngay++;
            }
            else
            {
                // Trường hợp 2: Đã hết tháng → chuyển sang ngày 1 tháng sau
                ngay = 1;

                if (thang < 12)
                {
                    // Nếu chưa hết năm → tăng tháng lên 1
                    thang++;
                }
                else
                {
                    // Nếu đã hết năm (tháng 12) → sang ngày 1/1 năm sau
                    thang = 1;
                    nam++;
                }
            }

            // Xuất kết quả
            // Ví dụ: "Ngay sau ngay 31/1/2015 la ngay 1/2/2015."
            Console.WriteLine("Ngay sau ngay {0}/{1}/{2} la ngay {3}/{4}/{5}.",
                ngayGoc, thangGoc, namGoc, ngay, thang, nam);
        }

        // ===================================================================
        // BÀI 4: PHÂN LOẠI TAM GIÁC (PhanLoaiTamGiac)
        // -------------------------------------------------------------------
        // Đề bài: Nhập vào ba số thực a, b, c.
        //         Hỏi ba số đó có tạo thành một tam giác không?
        //         Nếu có, nó tạo thành tam giác gì?
        //         (thường, cân, vuông, vuông cân, đều)
        //
        // Điều kiện tạo thành tam giác:
        //   Tổng 2 cạnh bất kỳ > cạnh còn lại
        //   ↔ a + b > c VÀ b + c > a VÀ a + c > b
        //
        // Phân loại:
        //   - Đều:      a == b == c
        //   - Vuông cân: 2 cạnh bằng nhau VÀ thỏa Pytago
        //   - Cân:      2 cạnh bằng nhau
        //   - Vuông:    a² + b² == c² (hoặc hoán vị)
        //   - Thường:   không thuộc loại nào ở trên
        // ===================================================================
        static void PhanLoaiTamGiac()
        {
            // In tiêu đề bài tập
            Console.WriteLine("--- BAI 4: PHAN LOAI TAM GIAC ---");

            // Khai báo 3 cạnh kiểu double (số thực)
            double a, b, c;

            // Nhập 3 cạnh
            Console.Write("Moi ban nhap ba so thuc a, b, c: ");
            string[] input = Console.ReadLine().Split(' ');

            // Chuyển chuỗi thành số thực
            a = double.Parse(input[0]); // Cạnh a
            b = double.Parse(input[1]); // Cạnh b
            c = double.Parse(input[2]); // Cạnh c

            // --- Kiểm tra điều kiện tạo thành tam giác ---
            // Ba số a, b, c tạo thành tam giác khi và chỉ khi:
            // a + b > c VÀ b + c > a VÀ a + c > b
            // (tổng 2 cạnh bất kỳ phải lớn hơn cạnh còn lại)
            if (a + b > c && b + c > a && a + c > b)
            {
                // Ba số tạo thành tam giác → tiến hành phân loại
                Console.Write("Ba so ({0}, {1}, {2}) tao thanh duoc tam giac. ", a, b, c);

                // Tính bình phương 3 cạnh (dùng để kiểm tra vuông)
                double a2 = a * a; // a²
                double b2 = b * b; // b²
                double c2 = c * c; // c²

                // Kiểm tra tam giác đều: 3 cạnh bằng nhau
                // a == b == c
                bool deu = (a == b) && (b == c);

                // Kiểm tra tam giác cân: có 2 cạnh bằng nhau
                // a == b HOẶC b == c HOẶC a == c
                bool can = (a == b) || (b == c) || (a == c);

                // Kiểm tra tam giác vuông: thỏa định lý Pytago
                // a² + b² = c² (hoặc hoán vị các cạnh)
                // Cạnh lớn nhất là cạnh huyền
                bool vuong = (a2 + b2 == c2) ||  // c là cạnh huyền
                             (b2 + c2 == a2) ||  // a là cạnh huyền
                             (a2 + c2 == b2);    // b là cạnh huyền

                // --- Phân loại chi tiết ---
                if (deu)
                {
                    // 3 cạnh bằng nhau → tam giác đều
                    Console.WriteLine("Tam giac deu.");
                }
                else if (can && vuong)
                {
                    // Vừa cân vừa vuông → tam giác vuông cân
                    Console.WriteLine("Tam giac vuong can.");
                }
                else if (can)
                {
                    // Chỉ cân (2 cạnh bằng nhau) → tam giác cân
                    Console.WriteLine("Tam giac can.");
                }
                else if (vuong)
                {
                    // Chỉ vuông (thỏa Pytago) → tam giác vuông
                    Console.WriteLine("Tam giac vuong.");
                }
                else
                {
                    // Không thuộc loại đặc biệt nào → tam giác thường
                    Console.WriteLine("Tam giac thuong.");
                }
            }
            else
            {
                // Không thỏa điều kiện → không tạo thành tam giác
                Console.WriteLine("Ba so ({0}, {1}, {2}) KHONG tao thanh duoc tam giac.",
                    a, b, c);
            }
        }

        // ===================================================================
        // HÀM MAIN - ĐIỂM BẮT ĐẦU CHƯƠNG TRÌNH
        // ===================================================================
        public static void Main(string[] args)
        {
            // Hiển thị tiêu đề
            Console.WriteLine("============================================");
            Console.WriteLine("  CHUONG 4: CAU LENH CHON LUA              ");
            Console.WriteLine("============================================");

            // Hiển thị menu
            Console.WriteLine("1. Diem trung binh          (DiemTrungBinh)");
            Console.WriteLine("2. Tinh tien nuoc           (TienNuoc)");
            Console.WriteLine("3. Ngay sau                 (NgaySau)");
            Console.WriteLine("4. Phan loai tam giac       (PhanLoaiTamGiac)");
            Console.WriteLine("--------------------------------------------");

            // Nhập lựa chọn
            Console.Write("Chon bai tap (1-4): ");
            int chon = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Rẽ nhánh theo lựa chọn
            switch (chon)
            {
                case 1: DiemTrungBinh(); break;
                case 2: TienNuoc(); break;
                case 3: NgaySau(); break;
                case 4: PhanLoaiTamGiac(); break;
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
