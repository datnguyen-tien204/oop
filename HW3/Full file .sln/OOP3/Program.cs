using System;
using OOP3;
namespace HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manage manage = new Manage();

            try
            {
                Console.Write("Nhap ten nguoi ban: ");
                string tenNguoiBan = Console.ReadLine();
                manage.AddEmployee(tenNguoiBan);

                Employee clerk = manage.FindEmployeeByName(tenNguoiBan);
                manage.CreateDiscountBill(clerk, true);

                Console.Write("Nhap so mat hang: ");
                int somh = int.Parse(Console.ReadLine());
                for (int i = 0; i < somh; i++)
                {
                    Console.Write("Nhap ten mat hang: ");
                    string tenmh = Console.ReadLine();
                    Console.Write("Nhap gia (Nhan dan te): ");
                    double giamh = double.Parse(Console.ReadLine());
                    Console.Write("Nhap giam gia (Nhan dan te): ");
                    double giamgiamh = double.Parse(Console.ReadLine());
                    manage.AddItemToBill(tenmh, giamh, giamgiamh);
                }
                manage.PrintBill();
            }
            catch (FormatException)
            {
                Console.WriteLine("Phai nhap so khong duoc chu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
