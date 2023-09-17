using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public Person(string name, string address, double salary)
        {
            Name = name;
            Address = address;
            Salary = salary;
        }

        public static Person InputPersonInfo()
        {

            string name;
            while (true)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Name isn't empty!");
                    continue;
                }
                break;
            }
            string address;
            while (true)
            {
                Console.Write("Input address: ");
                address = Console.ReadLine();
                if (address == "")
                {
                    Console.WriteLine("Address isn't empty");
                    continue;
                }
                break;
            }

            double salary;
            while (true)
            {
                Console.Write("Please input salary: ");
                string inputSalary = Console.ReadLine();

                if (!double.TryParse(inputSalary, out salary))
                {
                    Console.WriteLine("You must input a valid number for salary.");
                    continue;
                }

                if (salary < 0)
                {
                    Console.WriteLine("Salary must be a positive number.");
                    continue;
                }

                break;
            }

            return new Person(name, address, salary);
        }

        public static void DisplayPersonInfo(Person person)
        {

            Console.WriteLine("+------------+------------------+--------------+");
            Console.WriteLine("|Name        | Address          |  Salary      |");
            Console.WriteLine("+------------+------------------+--------------+");

            Console.WriteLine($"| {person.Name,-11}| {person.Address,-17}| {person.Salary,-13}|");


            Console.WriteLine("+------------+------------------+--------------+");
        }

        public static Person[] SortBySalary(Person[] people, int mode)
        {
            if (mode == 0)
            {
                for (int i = 0; i < people.Length - 1; i++)
                {
                    for (int j = 0; j < people.Length - 1 - i; j++)
                    {
                        if (people[j].Salary > people[j + 1].Salary)
                        {

                            Person temp = people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = temp;
                        }
                    }
                }

                return people;
            }
            else if (mode == 1)
            {
                for (int i = 0; i < people.Length - 1; i++)
                {
                    for (int j = 0; j < people.Length - 1 - i; j++)
                    {
                        if (people[j].Salary < people[j + 1].Salary)
                        {

                            Person temp = people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = temp;
                        }
                    }
                }

                return people;
            }
            else
            {
                return null;
            }

        }
    }
}
