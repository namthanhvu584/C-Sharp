// //check phan tu trong mang
// using System;

// class b27
// {
//     static void Main()
//     {
//         Console.Write("Nhập số phần tử của mảng: ");
//         int n = int.Parse(Console.ReadLine());

//         int[] array = new int[n];
//         Console.WriteLine("Nhập giá trị cho các phần tử của mảng:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Phần tử [{i}]: ");
//             array[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("\nDanh sách mảng đã nhập:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();

//         Console.Write("\nNhập phần tử k cần kiểm tra: ");
//         int k = int.Parse(Console.ReadLine());

//         int count = 0; // Đếm số lần xuất hiện của k
//         string positions = ""; // Lưu vị trí các phần tử

//         for (int i = 0; i < n; i++)
//         {
//             if (array[i] == k)
//             {
//                 count++;
//                 positions += i + " "; // Ghi lại vị trí
//             }
//         }

//         if (count > 0)
//         {
//             Console.WriteLine($"\nPhần tử {k} xuất hiện {count} lần trong mảng.");
//             Console.WriteLine($"Vị trí xuất hiện: {positions.Trim()}");
//         }
//         else
//         {
//             Console.WriteLine($"\nPhần tử {k} không tồn tại trong mảng.");
//         }
//     }
// }
