using System;

namespace Lab6
{
    // ===================================================================
    // BAI 1: IN HINH CHU I VA CHU U
    // Nhap vao chieu cao h. In chu I va chu U tuong ung.
    // Chu I: dong dau va dong cuoi day '*', cac dong giua chi co '*' o giua.
    // Chu U: cac dong tren co '*' o 2 canh, dong cuoi day '*'.
    // Vi du h = 5:
    //   * * * * * * *       *
    //       *           *       *
    //       *           *       *
    //       *           *   *   *
    //   * * * * * * * * * * * * *
    // ===================================================================
    static class InChuIvaU
    {
        public static void Run()
        {
            Console.WriteLine("--- BAI 1: IN HINH CHU I VA CHU U ---\n");

            int h = NhapLieu.NhapSoNguyen("Moi ban nhap chieu cao h: ", 3, 20);

            Console.WriteLine($"Chu I va U ung voi h = {h} la:");

            int width = 2 * h - 1;  // Chieu rong cua chu I va U

            for (int i = 1; i <= h; i++)
            {
                string line = "";

                // --- Phan chu I ---
                if (i == 1 || i == h)
                {
                    // Dong dau va dong cuoi: in day sao
                    for (int j = 1; j <= width; j++)
                    {
                        if (j % 2 == 1) line += "*";
                        else line += " ";
                    }
                }
                else
                {
                    // Dong giua: chi in sao o vi tri giua
                    for (int j = 1; j <= width; j++)
                    {
                        if (j == h) line += "*";
                        else line += " ";
                    }
                }

                line += "   "; // Khoang cach giua chu I va U

                // --- Phan chu U ---
                if (i == h)
                {
                    // Dong cuoi: in day sao
                    for (int j = 1; j <= width; j++)
                    {
                        if (j % 2 == 1) line += "*";
                        else line += " ";
                    }
                }
                else
                {
                    // Cac dong tren: in sao o 2 canh
                    for (int j = 1; j <= width; j++)
                    {
                        if (j == 1 || j == width) line += "*";
                        else line += " ";
                    }
                }

                Console.WriteLine(line);
            }
        }
    }
}
