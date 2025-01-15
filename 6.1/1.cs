using System;

class 1
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        int sumOfSquares = CalculateSumOfSquares(a, b);

        Console.WriteLine($"Tổng bình phương của {a} và {b} là: {sumOfSquares}");
    }

    static int CalculateSumOfSquares(int x, int y)
    {
        return x * x + y * y;
    }
}
