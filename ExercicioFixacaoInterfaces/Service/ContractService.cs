using ExercicioFixacaoInterfaces.Entities;

namespace ExercicioFixacaoInterfaces.Service
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            //            O processamento de
            //um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no
            //número de meses desejado.

            double basicQuota = contract.TotalValue / months;
            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota,i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
