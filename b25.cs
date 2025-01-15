// //heptb1
// using System;

// class b25
// {
//     static void Main()
//     {
//         Console.WriteLine("Giải hệ phương trình bậc nhất hai ẩn:");
//         Console.WriteLine("Dạng: a1*x + b1*y = c1 và a2*x + b2*y = c2");

//         Console.Write("Nhập a1: ");
//         double a1 = double.Parse(Console.ReadLine());

//         Console.Write("Nhập b1: ");
//         double b1 = double.Parse(Console.ReadLine());

//         Console.Write("Nhập c1: ");
//         double c1 = double.Parse(Console.ReadLine());

//         Console.Write("Nhập a2: ");
//         double a2 = double.Parse(Console.ReadLine());

//         Console.Write("Nhập b2: ");
//         double b2 = double.Parse(Console.ReadLine());

//         Console.Write("Nhập c2: ");
//         double c2 = double.Parse(Console.ReadLine());

//         double D = a1 * b2 - a2 * b1;
//         double Dx = c1 * b2 - c2 * b1;
//         double Dy = a1 * c2 - a2 * c1;

//         if (D != 0)
//         {
//             double x = Dx / D;
//             double y = Dy / D;
//             Console.WriteLine($"Hệ phương trình có nghiệm duy nhất: x = {x}, y = {y}");
//         }
//         else
//         {
//             if (Dx == 0 && Dy == 0)
//             {
//                 Console.WriteLine("Hệ phương trình có vô số nghiệm.");
//             }
//             else
//             {
//                 Console.WriteLine("Hệ phương trình vô nghiệm.");
//             }
//         }
//     }
// }
