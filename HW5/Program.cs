using System.Text;

namespace Bai5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng của ma trận A: ");
            int shA = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận A: ");
            int scA = int.Parse(Console.ReadLine());

            Matrix MatrixA = new Matrix(shA, scA);
            Console.WriteLine("Nhập ma trận A:");
            MatrixA.Nhap();

            Console.Write("Nhập số hàng của ma trận B: ");
            int shB = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận B: ");
            int scB = int.Parse(Console.ReadLine());

            Matrix MatrixB = new Matrix(shB, scB);
            Console.WriteLine("Nhập ma trận B:");
            MatrixB.Nhap();

            Console.WriteLine("Ma trận A:");
            MatrixA.Show();

            Console.WriteLine("Ma trận B:");
            MatrixB.Show();

            while (true)
            {
                Console.WriteLine("1. Tính tổng 2 ma trận");
                Console.WriteLine("2. Tính hiệu 2 ma trận");
                Console.WriteLine("3. Phép 2 ma trận");
                Console.WriteLine("4. Kiểm tra tính tương thích");
                Console.WriteLine("5. Xác định ma trận vuông");
                Console.WriteLine("0. Thoát");
                Console.Write("Hay nhap lua chon cua ban: ");
                int luachon = int.Parse(Console.ReadLine());

                if (luachon == 1)
                {
                    Matrix tong = MatrixA.Cong(MatrixB);
                    Console.WriteLine("Tổng hai ma trận:");
                    tong.Show();
                }
                if (luachon == 2)
                {
                    Matrix hieu = MatrixA.Hieu(MatrixB);
                    Console.WriteLine("Hiệu hai ma trận:");
                    hieu.Show();
                }
                if (luachon == 3)
                {
                    Matrix nhan = MatrixA.Nhan(MatrixB);
                    Console.WriteLine("Hiệu hai ma trận:");
                    nhan.Show();
                }
                if (luachon == 4)
                {
                    Boolean check = MatrixA.TuongThich(MatrixB);
                    if (check)
                    {
                        Console.WriteLine("Hai ma tran nay tuong thich");
                    }
                    else
                    {
                        Console.WriteLine("Hai ma tran nay khong tuong thich");
                    }
                }
                if (luachon == 5)
                {
                    Boolean check2 = MatrixA.MaTranVuong();
                    if (check2)
                    {
                        Console.WriteLine("Ma tran nay vuong");
                    }
                    else
                    {
                        Console.WriteLine("Ma tran nay khong vuong");
                    }
                }
                if (luachon == 0)
                {
                    break;
                }

            }
            Console.ReadKey();
        }
            
    }
}