namespace MetodosAbstratos.Entities
{
    public class Company : TaxPayer
    {
        public int NumberEmployees{ get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
           if (NumberEmployees >= 10) {
                return 0.14 * AnualIncome;
            }
           else
            {
                return 0.16 * AnualIncome;
            }
        }


    }
}
