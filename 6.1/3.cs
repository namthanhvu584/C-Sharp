using System;

class 3
{
    static void Main(string[] args)
    {
        // Nhập kích thước mảng
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        // Khởi tạo mảng và nhập giá trị
        int[] arr = new int[n];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // In ra phần tử âm
        Console.WriteLine("\nCác phần tử âm trong mảng:");
        PrintNegativeElements(arr);

        // In ra các phần tử lẻ
        Console.WriteLine("\nCác phần tử lẻ trong mảng:");
        PrintOddElements(arr);
    }

    // Hàm in ra các phần tử âm trong mảng
    static void PrintNegativeElements(int[] arr)
    {
        bool found = false;
        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.Write(num + " ");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không có phần tử âm nào trong mảng.");
        }
        else
        {
            Console.WriteLine();
        }
    }

    // Hàm in ra các phần tử lẻ trong mảng
    static void PrintOddElements(int[] arr)
    {
        bool found = false;
        foreach (int num in arr)
        {
            if (num % 2 != 0) // Phần tử lẻ khi chia hết cho 2 dư 1
            {
                Console.Write(num + " ");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không có phần tử lẻ nào trong mảng.");
        }
        else
        {
            Console.WriteLine();
        }
    }
}
