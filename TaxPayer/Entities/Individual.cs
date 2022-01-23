﻿namespace TaxPayer.Entities
{
    internal class Individual : TaxPayerClass
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0.0)
            {
                tax -= HealthExpenditures * 0.50;
            }

            return tax;
        }
    }
}
