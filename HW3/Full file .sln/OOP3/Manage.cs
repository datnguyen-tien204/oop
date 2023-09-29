using OOP3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3
{
    public class Manage
    {
        private List<Item> items;
        private List<Employee> employees;
        private GroceryBill groceryBill;


        public Manage()
        {
            items = new List<Item>();
            employees = new List<Employee>();
            groceryBill = null;
        }

        public void AddItem(string name, double price, double discount)
        {
            items.Add(new Item(name, price, discount));
        }

        public void AddEmployee(string name)
        {
            employees.Add(new Employee(name));
        }
        public void PrintBill()
        {
            if (groceryBill != null)
            {
                groceryBill.InHoaDon();
            }
            else
            {
                Console.WriteLine("Chua co hoa don nao.");
            }
        }
        public void CreateDiscountBill(Employee clerk, bool preferred)
        {
            groceryBill = new giamGiaBill(clerk, preferred);
        }
        public Employee FindEmployeeByName(string searchName)
        {
            return employees.Find(employee => employee.LayTen() == searchName);
        }
        public Item FindItemByName(string searchName)
        {
            return items.Find(item => item.LayTen() == searchName);
        }

        public void AddItemToBill(string itemName, double price, double discount)
        {
            if (groceryBill != null)
            {
                Item item = new Item(itemName, price, discount);
                groceryBill.Them(item);
            }
            else
            {
                Console.WriteLine("Hoa don trong");
            }
        }
    }
}
