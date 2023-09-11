using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            // Khởi tạo với ngày hiện tại của hệ thống
            DateTime currentDate = DateTime.Now;
            day = currentDate.Day;
            month = currentDate.Month;
            year = currentDate.Year;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void InputDate()
        {
            Console.Write("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine($"{month:D2}-{day:D2}-{year % 100:D2}");
        }

        public void NextDay()
        {
            // Xác định ngày tiếp theo
            DateTime currentDate = new DateTime(year, month, day);

            // Tính số ngày trong tháng hiện tại
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            if (currentDate.Day < daysInMonth)
            {
                // Nếu ngày hiện tại nhỏ hơn số ngày trong tháng, tăng ngày lên 1
                day++;
            }
            else
            {
                // Nếu ngày hiện tại là ngày cuối cùng của tháng, 
                // kiểm tra nếu tháng hiện tại là tháng cuối cùng của năm
                if (currentDate.Month == 12)
                {
                    // Nếu là tháng cuối cùng của năm, tăng năm lên 1 và đặt tháng và ngày thành 1
                    year++;
                    month = 1;
                    day = 1;
                }
                else
                {
                    // Nếu không phải tháng cuối cùng của năm, tăng tháng lên 1 và đặt ngày thành 1
                    month++;
                    day = 1;
                }
            }

            // Kiểm tra năm nhuận và tháng 2
            if (month == 2 && IsLeapYear(year))
            {
                daysInMonth = 29; // Tháng 2 có 29 ngày trong năm nhuận
            }

            if (day > daysInMonth)
            {
                // Nếu ngày vượt quá số ngày trong tháng, đặt ngày thành số ngày cuối cùng của tháng đó
                day = daysInMonth;
            }
        }

        // Hàm kiểm tra năm nhuận
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }


        public int CalculateDayDifference(Date datetime2)
        {
            DateTime currentDate = new DateTime(year, month, day);



            int thang2 = currentDate.Month;
            int nam2 = currentDate.Year;
            int ngay2 = currentDate.Day;

            int thang1 = datetime2.month;
            int nam1 = datetime2.year;
            int ngay1 = datetime2.day;
            int tongngay1 = 0;
            
            for (int i = 1; i < thang1; i++)
            {
                if (i == 2)
                {
                    if (nam1 % 4 == 0 && (nam1 % 100 != 0 || nam1 % 400 == 0)) //Thang2 nam nhuan co 29 ngayy
                    {
                        tongngay1 = tongngay1 + 29;
                    }
                    else //Khong nhuan co 28 ngay
                    {
                        tongngay1 = tongngay1 + 28;
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11) //Cac thang co 30 ngay
                {
                    tongngay1 = tongngay1 + 30;
                }
                else
                {
                    tongngay1 = tongngay1 + 31;
                }
            }

            // Tinh so ngay tu dau nam 2 den ngay 2
            int tongngay2 = ngay2 - 1;
            for (int i = 1; i < thang2; i++)
            {
                if (i == 2) //Thang 2 co ngay khuyet
                {
                    if (nam2 % 4 == 0 && (nam2 % 100 != 0 || nam2 % 400 == 0)) //Nam nhuan +29
                    {
                        tongngay2 = tongngay2 + 29;
                    }
                    else //Nam thuong +28
                    {
                        tongngay2 = tongngay2 + 28;
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11) //Cac thang co 30 ngay
                {
                    tongngay2 = tongngay2 + 30;
                }
                else
                {
                    tongngay2 = tongngay2 + 31;
                }
            }

            // Tinh so ngay giua cac nam
            int tongngay3 = 0;
            for (int i = nam1; i < nam2; i++)
            {
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0)) // Nam nhuan
                {
                    tongngay3 = tongngay3 + 366;
                }
                else // Nam thuong
                {
                    tongngay3 = tongngay3 + 365;
                }
            }
            Console.Clear();
            // Tinh tong so ngay
            int tongngay = tongngay1 + tongngay2 + tongngay3;
            
            return tongngay;
        }
    }
}
