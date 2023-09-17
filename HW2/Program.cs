using System.Security.Cryptography.X509Certificates;
namespace Hw2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== Management Person =====");

            int per_count = 0;

            Person[] people = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Input Person Information");
                Console.WriteLine("2. Show Person Information");
                Console.WriteLine("3. Display an ascending list by salary ");
                Console.WriteLine("4. Display an descending list by salary ");
                Console.WriteLine("5. Exit");


                //string choice = Console.ReadLine();
                double choice;
                while (true)
                {
                    Console.Write("Select an option: ");
                    string inputSalary = Console.ReadLine();

                    if (!double.TryParse(inputSalary, out choice))
                    {
                        Console.WriteLine("You must input a valid number for choice.");
                        continue;
                    }

                    if (choice < 0 && choice > 6)
                    {
                        Console.WriteLine("Choice not found.");
                        continue;
                    }

                    break;
                }

                string choice2 = choice.ToString();
                switch (choice2)
                {
                    case "1":
                        {
                            Console.Write("Please enter the number of people to add: ");
                            per_count = int.Parse(Console.ReadLine());

                            people = new Person[per_count];

                            for (int i = 0; i < per_count; i++)
                            {
                                Console.WriteLine($"Input Information of Person {i + 1}");
                                people[i] = Person.InputPersonInfo();
                            }
                            break;
                        }
                    case "2":
                        {
                            if (per_count == 0)
                            {
                                Console.WriteLine("Please input person information first.");
                                break;
                            }

                            int count = 1;
                            foreach (var person in people)
                            {
                                Console.WriteLine($"Information of Person {count} you have entered");
                                Person.DisplayPersonInfo(person);
                                count++;
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            if (per_count == 0)
                            {
                                Console.WriteLine("Please input person information first.");
                                break;
                            }

                            Console.WriteLine("Sorted Person List by Salary Ascending:");
                            people = Person.SortBySalary(people, 0);

                            int count = 1;
                            foreach (var person in people)
                            {
                                Console.WriteLine($"Information of Person {count}");
                                Person.DisplayPersonInfo(person);
                                count++;
                            }
                            Console.WriteLine("Press [Enter] to continue");
                            Console.ReadKey();
                            break;

                        }
                    case "4":
                        {
                            if (per_count == 0)
                            {
                                Console.WriteLine("Please input person information first.");
                                break;
                            }

                            Console.WriteLine("Sorted Person List by Salary Descending:");
                            people = Person.SortBySalary(people, 1);

                            int count = 1;
                            foreach (var person in people)
                            {
                                Console.WriteLine($"Information of Person {count}");
                                Person.DisplayPersonInfo(person);
                                count++;
                            }
                            Console.WriteLine("Press [Enter] to continue");
                            Console.ReadKey();

                            break;

                        }
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        Console.WriteLine("Press [Enter] to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}