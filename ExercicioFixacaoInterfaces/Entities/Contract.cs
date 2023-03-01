namespace ExercicioFixacaoInterfaces.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public Installment Installment { get; set; }

        public double TotalValue { get; set; }

        public Contract(int number, DateTime date, Installment installment)
        {
            Number = number;
            Date = date;
            Installment = installment;
        }
    }
}
