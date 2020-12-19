using System;
using System.Globalization;
using System.Collections.Generic;

namespace Mod6_List_fixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idEmployee);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percent);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
