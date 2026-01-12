class Program
{
    static void Main(string[] args)
    {
        // Создаем список сотрудников
        List<Employee> employees = new List<Employee>();

        // Добавляем менеджера
        employees.Add(new Manager("Alice", 5000m, 1500m));
        // Добавляем разработчика
        employees.Add(new Developer("Bob", 4000m, 300));

        // Выводим зарплату для каждого сотрудника
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee: {employee.Name}, Monthly Salary: {employee.CalculateMonthlySalary():C}");
        }
    }
}