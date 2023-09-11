using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class ComplexNumber
    {
        private double phanthuc; 
        private double phanao; 

        public ComplexNumber(double phanthuc, double phanao)
        {
            this.phanthuc = phanthuc;
            this.phanao = phanao;
        }

        // Phương thức hiển thị số phức ra màn hình
        public void Display()
        {
            Console.WriteLine($"{phanthuc} + {phanao}i");
        }

        // Phương thức cộng hai số phức
        public ComplexNumber Cong(ComplexNumber other)
        {
            double kqthuc = phanthuc + other.phanthuc;
            double kqao = phanao + other.phanao;
            return new ComplexNumber(kqthuc, kqao);
        }

        // Phương thức trừ hai số phức
        public ComplexNumber Tru(ComplexNumber other)
        {
            double kqthuc = phanthuc - other.phanthuc;
            double kqao = phanao - other.phanao;
            return new ComplexNumber(kqthuc, kqao);
        }

        // Phương thức nhân hai số phức
        public ComplexNumber Nhan(ComplexNumber other)
        {
            double kqthuc = (phanthuc * other.phanthuc) - (phanao * other.phanao);
            double kqao = (phanthuc * other.phanao) + (phanao * other.phanthuc);
            return new ComplexNumber(kqthuc, kqao);
        }

    }
}
