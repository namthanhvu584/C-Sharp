using System;
class 2
{
    static void Main(string[] args)
    {
        // Nhập giá trị n
        Console.Write("Nhập giá trị n: ");
        int n = int.Parse(Console.ReadLine());

        // Tính tổng S
        double sum = CalculateSum(n);

        // Hiển thị kết quả
        Console.WriteLine($"Tổng S = 1 + 1/2 + 1/3 + ... + 1/{n} là: {sum:F5}");
    }

    // Hàm tính tổng S
    static double CalculateSum(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i; // Phải dùng 1.0 để đảm bảo tính toán số thực
        }
        return sum;
    }
}
