using System.Text;

namespace TaxPayer.Entities
{
    abstract class TaxPayerClass
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayerClass(string name, double annualIncome)
        {
            Name = name;
            AnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
