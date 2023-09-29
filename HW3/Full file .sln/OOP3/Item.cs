using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Item
    {
        private string _ten;
        private double _gia;
        private double _giamGia;

        public Item(string _ten, double _gia, double _giamGia)
        {
            this._ten = _ten;
            this._gia = _gia;
            this._giamGia = _giamGia;
        }

        public string LayTen()
        {
            return _ten;
        }

        public double LayGia()
        {
            return _gia;
        }

        public double LayGiamGia()
        {
            return _giamGia;
        }
    }
}
