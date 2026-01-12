public abstract class Employee
{
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    // Виртуальный метод для расчета месячной зарплаты
    public virtual decimal CalculateMonthlySalary()
    {
        return BaseSalary;
    }
}