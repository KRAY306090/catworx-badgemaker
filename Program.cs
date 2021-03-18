using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);

        }
        static List<Employee> GetEmployees()
        {
            // I will return a list of strings
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Enter first name: (leave empty to exit): ");
                string firstName = Console.ReadLine();
                // Break if the user hits ENTER without typing a name
                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter the Id number: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the Url for Photo: ");
                string photoUrl = Console.ReadLine();

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;

        }
    }
}
