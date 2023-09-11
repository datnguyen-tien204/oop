using System;
using System.Text;

namespace MyPersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen = "Nguyễn Tiến Đạt";
            string maSinhVien = "10122119";
            string lop = "12422TN";
            string usernameGitHub = "datnguyen-tien204";
            string diaChiEmail = "nguyendatdtqn@gmail.com";

            Console.WriteLine($"Họ tên: {hoTen}\tMã sinh viên: {maSinhVien}\tLớp: {lop}\tGitHub: {usernameGitHub}\tEmail: {diaChiEmail}");
            Console.ReadLine();
        }
    }
}
