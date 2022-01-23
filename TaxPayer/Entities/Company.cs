namespace TaxPayer.Entities
{
    internal class Company : TaxPayerClass
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double annualIncome, int employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Tax()
        {
            double tax = 0;
            if (EmployeesNumber <= 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }

            return tax;
        }
    }
}
