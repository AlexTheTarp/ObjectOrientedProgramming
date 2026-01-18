using EmployeeExercise;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine();

        Employee[] employees = new Employee[3];

        employees[0] = new Employee("Noah Takahashi", "E001", "Software Developer", 4200.50);
        employees[1] = new Employee("Amir Hassan", "E002", "Project Manager", 5200.00);
        employees[2] = new Employee("Zoe Nkosi", "E003", "Junior Developer", 3800.75);

        foreach (Employee emp in employees)
        {
            emp.PrintEmployeeInfo();
        }
        Console.WriteLine();

        for (int i = 0; i < employees.Length; i++)
        {
            int nextIndex = (i + 1) % employees.Length;

            Console.WriteLine($"Comparison {i + 1}: {employees[i].name} vs {employees[nextIndex].name}");
            Console.WriteLine(employees[i].CompareSalary(employees[nextIndex]));
            Console.WriteLine();
        }

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}