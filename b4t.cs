// using System;

// struct HSSV
// {
//     public string MaHSSV; 
//     public string HoTen; 
//     public double DiemToan; 
//     public double DiemLy; 
//     public double DiemHoa;
//     public double DiemTBC; 
// }

// class b4t
// {
//     static void Main()
//     {
//         int n;

//         do
//         {
//             Console.Write("Nhập số lượng HSSV (5 < n < 50): ");
//             n = int.Parse(Console.ReadLine());
//         } while (n <= 5 || n >= 50);

//         HSSV[] danhSachHSSV = new HSSV[n];

//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine($"\nNhập thông tin HSSV thứ {i + 1}:");

//             Console.Write("Mã HSSV: ");
//             danhSachHSSV[i].MaHSSV = Console.ReadLine();

//             Console.Write("Họ và Tên: ");
//             danhSachHSSV[i].HoTen = Console.ReadLine();

//             Console.Write("Điểm Toán: ");
//             danhSachHSSV[i].DiemToan = double.Parse(Console.ReadLine());

//             Console.Write("Điểm Lý: ");
//             danhSachHSSV[i].DiemLy = double.Parse(Console.ReadLine());

//             Console.Write("Điểm Hóa: ");
//             danhSachHSSV[i].DiemHoa = double.Parse(Console.ReadLine());

//             danhSachHSSV[i].DiemTBC = (danhSachHSSV[i].DiemToan + danhSachHSSV[i].DiemLy + danhSachHSSV[i].DiemHoa) / 3;
//         }

//         Console.WriteLine("\nDanh sách HSSV:");
//         Console.WriteLine("Mã HSSV\tHọ và Tên\tĐiểm Toán\tĐiểm Lý\tĐiểm Hóa\tĐiểm TBC");
//         foreach (var hssv in danhSachHSSV)
//         {
//             Console.WriteLine($"{hssv.MaHSSV}\t{hssv.HoTen}\t{hssv.DiemToan}\t\t{hssv.DiemLy}\t{hssv.DiemHoa}\t\t{hssv.DiemTBC:F2}");
//         }

//         HSSV hssvMaxTBC = danhSachHSSV[0];
//         foreach (var hssv in danhSachHSSV)
//         {
//             if (hssv.DiemTBC > hssvMaxTBC.DiemTBC)
//             {
//                 hssvMaxTBC = hssv;
//             }
//         }
//         Console.WriteLine($"\nHSSV có điểm TBC lớn nhất: {hssvMaxTBC.HoTen} (Mã: {hssvMaxTBC.MaHSSV}) với điểm TBC: {hssvMaxTBC.DiemTBC:F2}");

//         HSSV hssvMinTBC = danhSachHSSV[0];
//         foreach (var hssv in danhSachHSSV)
//         {
//             if (hssv.DiemTBC < hssvMinTBC.DiemTBC)
//             {
//                 hssvMinTBC = hssv;
//             }
//         }
//         Console.WriteLine($"\nHSSV có điểm TBC nhỏ nhất: {hssvMinTBC.HoTen} (Mã: {hssvMinTBC.MaHSSV}) với điểm TBC: {hssvMinTBC.DiemTBC:F2}");

//         double tongDiemTBC = 0;
//         foreach (var hssv in danhSachHSSV)
//         {
//             tongDiemTBC += hssv.DiemTBC;
//         }
//         double diemTBCLop = tongDiemTBC / n;
//         Console.WriteLine($"\nĐiểm TBC cột TBC của cả lớp: {diemTBCLop:F2}");

//         Console.WriteLine("\nDanh sách HSSV có điểm TBC < 5:");
//         foreach (var hssv in danhSachHSSV)
//         {
//             if (hssv.DiemTBC < 5)
//             {
//                 Console.WriteLine($"{hssv.MaHSSV}\t{hssv.HoTen}\t{hssv.DiemTBC:F2}");
//             }
//         }
//     }
// }
