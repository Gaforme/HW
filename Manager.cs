public class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string name, decimal baseSalary, decimal bonus)
        : base(name, baseSalary)
    {
        Bonus = bonus;
    }

    // Переопределяем метод для расчета зарплаты с учетом бонуса
    public override decimal CalculateMonthlySalary()
    {
        return BaseSalary + Bonus;
    }
}