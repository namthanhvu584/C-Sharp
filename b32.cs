// using System;

// class b32
// {
//     static void Main()
//     {
//         int[] A = new int[100];
//         int n;

//         do
//         {
//             Console.Write("Nhập số phần tử của mảng (5 < n < 50): ");
//             n = int.Parse(Console.ReadLine());
//         } while (n <= 5 || n >= 50);

//         Console.WriteLine("Nhập các phần tử của mảng:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"A[{i}] = ");
//             A[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("\nMảng đã nhập:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(A[i] + " ");
//         }
//         Console.WriteLine();

//         Console.Write("\nNhập số nguyên x: ");
//         int x = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Các vị trí tìm thấy {x} trong mảng:");
//         bool found = false;
//         for (int i = 0; i < n; i++)
//         {
//             if (A[i] == x)
//             {
//                 Console.WriteLine($"Vị trí: {i}");
//                 found = true;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine("Không tìm thấy x trong mảng.");
//         }

//         Console.Write("\nNhập số nguyên y: ");
//         int y = int.Parse(Console.ReadLine());

//         int sum = 0;
//         for (int i = 0; i < n; i++)
//         {
//             if (A[i] % y == 0)
//             {
//                 sum += A[i];
//             }
//         }
//         Console.WriteLine($"Tổng các phần tử chia hết cho {y} là: {sum}");

//         Array.Sort(A, 0, n);
//         Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(A[i] + " ");
//         }
//         Console.WriteLine();
//     }
// }
