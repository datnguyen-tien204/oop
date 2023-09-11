namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap moc thoi gian bat dau");
            Date startDate = new Date();
            startDate.InputDate();

            Date currentDate = new Date();

            int dayDifference = currentDate.CalculateDayDifference(startDate);

            Console.WriteLine($"Khoang cach: {dayDifference} ngay");

            Console.WriteLine("Ngay hien tai:");
            currentDate.PrintDate();

            // Tăng ngày hiện tại lên 1 ngày và in ra
            currentDate.NextDay();
            Console.WriteLine("Ngay tiep theo:");
            currentDate.PrintDate();
        }
    }
}