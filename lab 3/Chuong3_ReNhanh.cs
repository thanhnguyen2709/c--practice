/*
}
        // ===================================================================
        // HÀM MAIN - ÐI?M B?T Ð?U CHUONG TRÌNH
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
            int chon = int.Parse(Console.ReadLine());
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
