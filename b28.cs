// using System;

// class b28
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

//         // Tìm giá trị lớn nhất
//         int max = array[0];
//         foreach (int value in array)
//         {
//             if (value > max)
//             {
//                 max = value;
//             }
//         }

//         // Tìm giá trị nhỏ nhất
//         int min = array[0];
//         foreach (int value in array)
//         {
//             if (value < min)
//             {
//                 min = value;
//             }
//         }

//         Console.WriteLine($"\nGiá trị lớn nhất trong mảng: {max}");
//         Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {min}");

//         // Sắp xếp mảng tăng dần
//         Array.Sort(array);
//         Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
//         foreach (int value in array)
//         {
//             Console.Write(value + " ");
//         }

//         // Sắp xếp mảng giảm dần
//         Array.Reverse(array);
//         Console.WriteLine("\n\nMảng sau khi sắp xếp giảm dần:");
//         foreach (int value in array)
//         {
//             Console.Write(value + " ");
//         }
//     }
// }
