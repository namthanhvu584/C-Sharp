using System;

class PhanSo
{
    // Thuộc tính
    private int tuSo;    // Tử số
    private int mauSo;   // Mẫu số

    // Hàm khởi tạo không tham số
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Hàm khởi tạo có tham số
    public PhanSo(int tuSo, int mauSo)
    {
        this.tuSo = tuSo;
        this.mauSo = mauSo != 0 ? mauSo : 1; // Đảm bảo mẫu số khác 0
    }

    // Hàm nhập phân số
    public void Nhap()
    {
        Console.Write("Nhập tử số: ");
        tuSo = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Nhập mẫu số (khác 0): ");
            mauSo = int.Parse(Console.ReadLine());
            if (mauSo == 0)
                Console.WriteLine("Mẫu số phải khác 0. Vui lòng nhập lại!");
        } while (mauSo == 0);
    }

    // Hàm xuất phân số
    public void Xuat()
    {
        if (mauSo == 1) Console.WriteLine($"{tuSo}");
        else Console.WriteLine($"{tuSo}/{mauSo}");
    }

    // Hàm rút gọn phân số
    private void RutGon()
    {
        int gcd = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
        tuSo /= gcd;
        mauSo /= gcd;

        // Đảm bảo mẫu số dương
        if (mauSo < 0)
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
    }

    // Hàm tính UCLN (Ước chung lớn nhất)
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Hàm cộng hai phân số
    public PhanSo Cong(PhanSo ps)
    {
        int tu = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo result = new PhanSo(tu, mau);
        result.RutGon();
        return result;
    }

    // Hàm trừ hai phân số
    public PhanSo Tru(PhanSo ps)
    {
        int tu = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo result = new PhanSo(tu, mau);
        result.RutGon();
        return result;
    }

    // Hàm nhân hai phân số
    public PhanSo Nhan(PhanSo ps)
    {
        int tu = this.tuSo * ps.tuSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo result = new PhanSo(tu, mau);
        result.RutGon();
        return result;
    }

    // Hàm chia hai phân số
    public PhanSo Chia(PhanSo ps)
    {
        int tu = this.tuSo * ps.mauSo;
        int mau = this.mauSo * ps.tuSo;
        PhanSo result = new PhanSo(tu, mau);
        result.RutGon();
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập phân số thứ nhất:");
        PhanSo ps1 = new PhanSo();
        ps1.Nhap();

        Console.WriteLine("Nhập phân số thứ hai:");
        PhanSo ps2 = new PhanSo();
        ps2.Nhap();

        // Thực hiện các phép tính
        Console.WriteLine("\nKết quả:");
        PhanSo tong = ps1.Cong(ps2);
        Console.Write("Tổng: ");
        tong.Xuat();

        PhanSo hieu = ps1.Tru(ps2);
        Console.Write("Hiệu: ");
        hieu.Xuat();

        PhanSo tich = ps1.Nhan(ps2);
        Console.Write("Tích: ");
        tich.Xuat();

        PhanSo thuong = ps1.Chia(ps2);
        Console.Write("Thương: ");
        thuong.Xuat();
    }
}
