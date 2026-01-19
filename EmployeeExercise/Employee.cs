namespace EmployeeExercise
{
    class Employee
    {
        public string name;
        private string id;
        private string position;
        private double salary;

        public Employee()
        {
            name = "Unknown";
            id = "00000";
            position = "Unknown";
            salary = 0.0;
        }
        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public string CompareSalary(Employee other)
        {
            if (other == null)
            {
                return "Cannot compare with null employee";
            }

            if (this.salary > other.salary)
            {
                return $"{this.name}, {this.position} earns more than {other.name}, {other.position}: {this.salary:C} vs {other.salary:C}";
            }
            else if (this.salary < other.salary)
            {
                return $"{other.name}, {other.position} earns more than {this.name}, {this.position}: {other.salary:C} vs {this.salary:C}";
            }
            else
            {
                return $"{this.name} and {other.name} have the same salary: {this.salary:C}";
            }
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Employee: {name}\n" +
                   $"ID: {id}\n" +
                   $"Position: {position}\n" +
                   $"Salary: {salary:C}";
        }
    }
}