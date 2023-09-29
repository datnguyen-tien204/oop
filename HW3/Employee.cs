using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Employee
    {
        private string _ten;

        public Employee(string _ten)
        {
            this._ten = _ten;
        }
        public string LayTen()
        {
            return _ten;
        }
    }
}
