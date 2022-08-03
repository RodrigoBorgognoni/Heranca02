using System;
using System.Collections.Generic;
using Heranca02.Entities;

namespace Heranca02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                if (ch == 'Y')
                {
                    Console.Write("Additional Charge: ");
                    double acharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, value, acharge));

                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                }
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment():C}");
            }
        }
    }
}
