class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Manager("Alice", 5000m, 1500m));
        employees.Add(new Developer("Bob", 4000m, 300));

        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Monthly Salary: {employee.CalculateMonthlySalary():C}");
        }
    }
}