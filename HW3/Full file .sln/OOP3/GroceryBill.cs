using HW3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class GroceryBill
    {
        protected List<Item> items;
        private Employee nguoiBan;
        public GroceryBill(Employee nguoiBan)
        {
            this.nguoiBan = nguoiBan;
            items = new List<Item>();
        }
        public void Them(Item i)
        {
            items.Add(i);
        }
        public virtual double TinhTong()
        {
            try
            {
                double tong = 0;
                foreach (Item item in items)
                {
                    tong += item.LayGia();
                }
                return tong;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Khong co mat hang nao trong hoa don.");
                return 0;
            }

        }

        public void InHoaDon()
        {
            Console.WriteLine("Hoa don mua sam");
            Console.WriteLine("Ten nhan vien: " + nguoiBan.LayTen());
            Console.WriteLine("San pham:");
            foreach (Item item in items)
            {
                Console.WriteLine(item.LayTen() + " - $" + item.LayGia());
            }
            Console.WriteLine("Tong: $" + TinhTong());
        }
    }
}
