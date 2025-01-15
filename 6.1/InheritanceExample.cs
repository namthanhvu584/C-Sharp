using System;

namespace InheritanceExample
{
    // Lớp Person
    public class Person
    {
        protected int age;

        public void Hello()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    // Lớp Student kế thừa từ Person
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old.");
        }
    }

    // Lớp Teacher kế thừa từ Person
    public class Teacher : Person
    {
        public void Teach()
        {
            Console.WriteLine("I'm teaching.");
        }
    }

    // Lớp Program chứa phương thức Main
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một Người mới và giúp anh ấy nói lời chào
            Person person = new Person();
            person.Hello();

            // Tạo Sinh viên mới, đặt tuổi, chào và hiển thị tuổi của SV trên màn hình
            Student student = new Student();
            student.SetAge(20); // Đặt tuổi
            student.Hello();    // Nói lời chào
            student.ShowAge();  // Hiển thị tuổi
            student.Study();    // Sinh viên học

            // Tạo Giáo viên mới, đặt tuổi, chào và bắt đầu giảng dạy
            Teacher teacher = new Teacher();
            teacher.SetAge(40); // Đặt tuổi
            teacher.Hello();    // Nói lời chào
            teacher.Teach();    // Giáo viên giảng dạy

            // Dừng màn hình để xem kết quả
            Console.ReadLine();
        }
    }
}
