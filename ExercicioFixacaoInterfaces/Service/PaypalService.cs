namespace ExercicioFixacaoInterfaces.Service
{
    internal class PaypalService : IOnlinePaymentService
    {
        private readonly double _monthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * _monthlyInterest * months;
        }

        //O problema já diz que a taxa de pagamento é de 2 %
        public double PaymentFee(double amount)
        {
            return amount * 0.2;
        }
    }
}
