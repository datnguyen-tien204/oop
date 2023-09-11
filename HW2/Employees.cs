using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Employees
    {
        private int nextId = 1;
        private int id; // Định danh
        private string name; // Họ tên
        private int yearOfBirth; // Năm sinh
        private double salaryLevel; // Bậc lương
        private static double basicSalary;

        public Employees(string name, int yearOfBirth, double salaryLevel)
        {
            this.id = nextId++; // Tạo định danh và tăng nextId
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
        }
        public int GetID()
        {
            return id;
        }
        public string GetName() 
        {
            return name;
        }
        public int GetYearOfBirth()
        {
              return yearOfBirth;
        }
        public double GetIncome()
        {
            return salaryLevel*basicSalary;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Náme: {name}");
            Console.WriteLine($"Year of birth: {yearOfBirth}");
            Console.WriteLine($"Basics Salary: {basicSalary}");
            Console.WriteLine($"Get Income: {GetIncome()}");
        }
        public void SetSalaryLevel(double salaryLevel)
        {
            this.salaryLevel = salaryLevel;
        }

        // Phương thức thiết lập lương cơ bản (chung cho tất cả đối tượng Employee)
        public static void SetBasicSalary(double basicSalary)
        {
            Employees.basicSalary = basicSalary;
        }
    }
}
