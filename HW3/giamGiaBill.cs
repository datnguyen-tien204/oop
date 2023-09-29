using HW3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class giamGiaBill: GroceryBill
    {
        private bool uuDai;
        private int soLanGiamGia;
        private double soTienGiamGia;

        public giamGiaBill(Employee nguoiBan, bool uuDai)
            : base(nguoiBan)
        {
            this.uuDai = uuDai;
            soLanGiamGia = 0;
            soTienGiamGia = 0;
        }

        public override double TinhTong()
        {
            if (uuDai)
            {
                try
                {
                    double tong = 0;
                    foreach (Item item in items)
                    {
                        double giamGia = item.LayGiamGia();
                        if (giamGia > 0)
                        {
                            soLanGiamGia++;
                            soTienGiamGia += giamGia;
                        }
                        tong += item.LayGia() - giamGia;
                    }
                    return tong;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Khong co mat hang nao trong hoa don.");
                    return 0;
                }

            }
            else
            {
                return base.TinhTong();
            }
        }

        public int LaySoLanGiamGia()
        {
            return soLanGiamGia;
        }
        public double LaySoTienGiamGia()
        {
            return soTienGiamGia;
        }
        public double LayTiLeGiamGia()
        {
            double tong = base.TinhTong();
            if (tong > 0)
            {
                try
                {
                    return soTienGiamGia / tong * 100;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi+ {e.Message}");
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
