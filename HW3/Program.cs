namespace Bai3
{
    class Program
    {
        static void Main(string[] args) 
        {
            while (true) 
            {
                Console.WriteLine( );
                Console.WriteLine("1. Them mot phan tu moi vao stack");
                Console.WriteLine("2. Bo mot phan tu ra khoi stack");
                Console.WriteLine("3. Hien thi stack");
                Console.WriteLine("0. Thoat");

                Console.Write("Hay nhap lua chon cua ban: ");
                int choose=int.Parse(Console.ReadLine());
                Stack stk = new Stack();

           
                if (choose == 1)
                {
                    Console.WriteLine("Truoc khi PUSH");
                    Console.WriteLine();
                    stk.ShowStack();
                    Console.WriteLine();
                    Console.Write("Hay nhap mot gia tri can them vao stack: ");
                    int vl = int.Parse(Console.ReadLine());
                    stk.Push(vl);
                    Console.WriteLine("Sau khi PUSH");
                    stk.ShowStack();
                    Console.WriteLine();
                }
                if (choose == 2) 
                {
                    
                    Console.WriteLine("Truoc khi POP");
                    stk.ShowStack();
                    Console.WriteLine( );
                    stk.Pop();
                    Console.WriteLine("Sau khi POP");
                        
                }
                if(choose == 3) 
                {
                    stk.ShowStack();
                }
            }
        }
          
    }
}