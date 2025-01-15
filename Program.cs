using System;
using System.Collections.Generic;

class Program
{
    // Thông tin cá nhân
    // Họ và tên: Vu Tan Nam
    // Ngày sinh: 15/06/2002
    // Mã sinh viên: 22110088

    static void Main(string[] args)
    {
        // Khai báo thông tin cá nhân
        const int ngaySinh = 15;
        const int thangSinh = 6;
        const int namSinh = 2002;
        const int soCuoiNamSinh = namSinh % 10;

        // Tính Max
        int Max = ngaySinh + thangSinh + soCuoiNamSinh;

        // Nhập n
        int n;
        do
        {
            Console.Write($"Nhập số phần tử của mảng (0 < n < {Max}): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0 || n >= Max);

        // Khai báo mảng
        float[] mang = new float[n];

        // Nhập giá trị cho mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            mang[i] = float.Parse(Console.ReadLine());
        }

        // Tính tổng chữ số hàng chục và hàng đơn vị của tháng sinh
        int tongChuSoThangSinh = thangSinh / 10 + thangSinh % 10;

        // In ra các phần tử có phần nguyên chia hết cho tổng chữ số hàng chục và hàng đơn vị của tháng sinh
        Console.WriteLine("\nCác phần tử có phần nguyên chia hết cho tổng chữ số hàng chục và hàng đơn vị của tháng sinh:");
        foreach (float phanTu in mang)
        {
            int phanNguyen = (int)phanTu;
            if (phanNguyen % tongChuSoThangSinh == 0)
            {
                Console.WriteLine(phanTu);
            }
        }

        // Kiểm tra phần tử x có trong danh sách hay không
        Console.Write("\nNhập giá trị x cần kiểm tra: ");
        float x = float.Parse(Console.ReadLine());
        bool xTonTai = Array.Exists(mang, phanTu => phanTu == x);
        if (xTonTai)
        {
            Console.WriteLine($"Phần tử {x} có tồn tại trong mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {x} không tồn tại trong mảng.");
        }

        // Đếm số lần xuất hiện của phần tử y trong danh sách
        Console.Write("\nNhập giá trị y cần đếm số lần xuất hiện: ");
        float y = float.Parse(Console.ReadLine());
        int dem = 0;
        foreach (float phanTu in mang)
        {
            if (phanTu == y)
            {
                dem++;
            }
        }
        Console.WriteLine($"Phần tử {y} xuất hiện {dem} lần trong mảng.");

        Console.WriteLine("\nKết thúc chương trình.");
    }
}
