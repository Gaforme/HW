public class Developer : Employee
{
    public int LinesOfCodeWritten { get; set; }
    private const decimal BonusPerLineOfCode = 0.01m; // Премия за строку кода

    public Developer(string name, decimal baseSalary, int linesOfCodeWritten)
        : base(name, baseSalary)
    {
        LinesOfCodeWritten = linesOfCodeWritten;
    }

    // Переопределяем метод для расчета зарплаты с учетом премии
    public override decimal CalculateMonthlySalary()
    {
        return BaseSalary + (LinesOfCodeWritten * BonusPerLineOfCode);
    }
}