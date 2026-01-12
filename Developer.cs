public class Developer : Employee
{
    public int LinesOfCodeWritten { get; set; }
    private const decimal BonusPerLineOfCode = 0.01m;

    public Developer(string name, decimal baseSalary, int linesOfCodeWritten)
        : base(name, baseSalary)
    {
        LinesOfCodeWritten = linesOfCodeWritten;
    }

    public override decimal CalculateMonthlySalary()
    {
        return BaseSalary + (LinesOfCodeWritten * BonusPerLineOfCode);
    }
}