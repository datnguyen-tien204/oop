namespace Bai4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap phan thuc so phuc 1: ");
            int pts1=int.Parse(Console.ReadLine());

            Console.Write("Nhap phan ao so phuc 1: ");
            int pas1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap phan thuc so phuc 2: ");
            int pts2= int.Parse(Console.ReadLine());

            Console.Write("Nhap phan ao so phuc 2: ");
            int pas2 = int.Parse(Console.ReadLine());
            ComplexNumber complex1 = new ComplexNumber(pts1, pas1);
            ComplexNumber complex2 = new ComplexNumber(pts2, pas2);

            Console.Write("So phuc 1: ");
            complex1.Display();

            Console.Write("So phuc 2: ");
            complex2.Display();

            ComplexNumber tong = complex1.Cong(complex2);
            Console.Write("Tong 2 so phuc: ");
            tong.Display();

            ComplexNumber tru= complex1.Tru(complex2);
            Console.Write("Hiieu 2 so phuc:");
            tru.Display();

            ComplexNumber tich = complex1.Nhan(complex2);
            Console.Write("Tich 2 so phuc");
            tich.Display();

            Console.ReadLine();
        }
    }
}