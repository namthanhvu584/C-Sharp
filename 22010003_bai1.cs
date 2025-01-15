using System;
using System.Collections.Generic;

class Program
{
    /* Họ và tên: Vũ Thành Nam
        Ngày sinh:05/08/2004
        MSSV: 22010003
    */
    static void Main(string[] args)
    {
        const int ngaySinh = 05;
        const int thangSinh = 08;
        const int namSinh = 2004;
        const int soCuoiNamSinh = namSinh % 10;

        int Max = ngaySinh + thangSinh + soCuoiNamSinh;

        int n;
        do
        {
            Console.Write($"Nhap so phan tu trong mang (0 < n < {Max}): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0 || n >= Max);

        float[] mang = new float[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = float.Parse(Console.ReadLine());
        }

        int tongChuSoThangSinh = thangSinh / 10 + thangSinh % 10;

        Console.WriteLine("\nCác phần tử có phần nguyên chia hết cho tổng chữ số hàng chục và hàng đơn vị của tháng sinh:");
        foreach (float phanTu in mang)
        {
            int phanNguyen = (int)phanTu;
            if (phanNguyen % tongChuSoThangSinh == 0)
            {
                Console.WriteLine(phanTu);
            }
        }

        Console.Write("\nNhap gia tri x can tim: ");
        float x = float.Parse(Console.ReadLine());
        bool xTonTai = Array.Exists(mang, phanTu => phanTu == x);
        if (xTonTai)
        {
            Console.WriteLine($"Phan tu {x} ton tai trong mang.");
        }
        else
        {
            Console.WriteLine($"Phan tu {x} khong  ton tai trong mang .");
        }

        Console.Write("\nNhap gia tri y can dem xuat hien trong mang: ");
        float y = float.Parse(Console.ReadLine());
        int dem = 0;
        foreach (float phanTu in mang)
        {
            if (phanTu == y)
            {
                dem++;
            }
        }
        Console.WriteLine($"Phan tu {y} xuat hien {dem} lan trong mang.");

        Console.WriteLine("\nKết thúc chương trình.");
    }
}
