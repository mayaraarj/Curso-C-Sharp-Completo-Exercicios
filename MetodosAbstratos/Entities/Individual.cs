namespace MetodosAbstratos.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double anualIncome, double healthExpenses) : base(name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000 && HealthExpenses > 0) 
            {
                return AnualIncome * 0.15 - (HealthExpenses * 0.5);
            }
            else if (AnualIncome < 20000 && HealthExpenses == 0)
            {
                return AnualIncome * 0.15;
            }
            else if (AnualIncome >= 20000 && HealthExpenses > 0)
            {
                return AnualIncome * 0.25 - (HealthExpenses * 0.5);
            }
            else
            {
                return AnualIncome * 0.25;
            }
        }
    }
}
