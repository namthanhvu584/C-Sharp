using System;

namespace StudentApp
{
    // Lớp cơ sở
    class Student
    {
        // Thuộc tính
        public string MaSinhVien { get; set; }
        public string HoVaTen { get; set; }

        // Phương thức khởi tạo không tham số
        public Student()
        {
            MaSinhVien = "SV0000";
            HoVaTen = "Chua nhap";
        }

        // Phương thức khởi tạo có tham số
        public Student(string maSinhVien, string hoVaTen)
        {
            MaSinhVien = maSinhVien;
            HoVaTen = hoVaTen;
        }

        // Phương thức in thông tin
        public virtual void InThongTin()
        {
            Console.WriteLine($"Mã sinh viên: {MaSinhVien}");
            Console.WriteLine($"Họ và tên: {HoVaTen}");
        }
    }

    // Lớp kế thừa thứ nhất
    class UndergraduateStudent : Student
    {
        // Thuộc tính mới
        public int NamHoc { get; set; }

        // Phương thức nhập dữ liệu có tham số
        public void NhapDuLieu(string maSinhVien, string hoVaTen, int namHoc)
        {
            MaSinhVien = maSinhVien;
            HoVaTen = hoVaTen;
            NamHoc = namHoc;
        }

        // Ghi đè phương thức in thông tin
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Năm học: {NamHoc}");
        }
    }

    // Lớp kế thừa thứ hai
    class GraduateStudent : Student
    {
        // Thuộc tính mới
        public string NganhHoc { get; set; }

        // Phương thức tĩnh
        public static void GioiThieu()
        {
            Console.WriteLine("Đây là lớp dành cho sinh viên sau đại học.");
        }

        // Ghi đè phương thức in thông tin
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Ngành học: {NganhHoc}");
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo đối tượng của lớp cơ sở
            Console.WriteLine("=== Lớp cơ sở ===");
            Student student = new Student("SV22110088", "Vu Tan Nam");
            student.InThongTin();

            // Khai báo và khởi tạo đối tượng của lớp kế thừa thứ nhất
            Console.WriteLine("\n=== Lớp kế thừa thứ nhất ===");
            UndergraduateStudent uStudent = new UndergraduateStudent();
            uStudent.NhapDuLieu("SV22110089", "Nguyen Van A", 3);
            uStudent.InThongTin();

            // Khai báo và khởi tạo đối tượng của lớp kế thừa thứ hai
            Console.WriteLine("\n=== Lớp kế thừa thứ hai ===");
            GraduateStudent.GioiThieu();
            GraduateStudent gStudent = new GraduateStudent
            {
                MaSinhVien = "SV22110090",
                HoVaTen = "Tran Thi B",
                NganhHoc = "Khoa hoc may tinh"
            };
            gStudent.InThongTin();

            Console.WriteLine("\nChương trình kết thúc.");
        }
    }
}
