// using System;

// class b33
// {
//     static void Main()
//     {
//         Console.Write("Nhập số phần tử của mảng thứ nhất: ");
//         int n1 = int.Parse(Console.ReadLine());
//         int[] array1 = new int[n1];

//         Console.WriteLine("Nhập các phần tử của mảng thứ nhất:");
//         for (int i = 0; i < n1; i++)
//         {
//             Console.Write($"array1[{i}] = ");
//             array1[i] = int.Parse(Console.ReadLine());
//         }

//         Console.Write("Nhập số phần tử của mảng thứ hai: ");
//         int n2 = int.Parse(Console.ReadLine());
//         int[] array2 = new int[n2];

//         Console.WriteLine("Nhập các phần tử của mảng thứ hai:");
//         for (int i = 0; i < n2; i++)
//         {
//             Console.Write($"array2[{i}] = ");
//             array2[i] = int.Parse(Console.ReadLine());
//         }

//         int[] array3 = new int[n1 + n2];
//         for (int i = 0; i < n1; i++)
//         {
//             array3[i] = array1[i];
//         }
//         for (int i = 0; i < n2; i++)
//         {
//             array3[n1 + i] = array2[i];
//         }

//         Array.Sort(array3);

//         Console.WriteLine("\nMảng thứ ba sau khi hợp nhất và sắp xếp tăng dần:");
//         foreach (int value in array3)
//         {
//             Console.Write(value + " ");
//         }
//         Console.WriteLine();
//     }
// }
