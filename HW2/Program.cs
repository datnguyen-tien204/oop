using System;
namespace Bai2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap muc luong co ban dau: ");
            double empl=double.Parse(Console.ReadLine());
            Employees.SetBasicSalary(empl);

            // Tạo một đối tượng Employee
            Console.Write("Nhap ten cua nhan vien: ");
            string name = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Nhap bac luong: ");
            double salaryLevel = double.Parse(Console.ReadLine());

            Employees employee1 = new Employees(name, year, salaryLevel);

            // Hiển thị thông tin của đối tượng Employee
            Console.WriteLine("Info of WOrker 1:");
            employee1.Display();

            // Thiết lập bậc lương mới
            employee1.SetSalaryLevel(3.0);

            // Hiển thị thông tin cập nhật
            Console.WriteLine("Information after update salary level:");
            employee1.Display();

            Console.ReadLine();
        }
    }
}
