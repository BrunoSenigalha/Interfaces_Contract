using Contrato_Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato_Interfaces.Services
{
    internal class ContractService
    {
        public IPaymentService PaymentService { get; set; }

        public ContractService(IPaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            double installmentValue = contract.TotalValue / mounths;

            for (int i = 1; i <= mounths; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updateQuota = installmentValue + PaymentService.Interest(installmentValue, i);
                double fullQuota = installmentValue + PaymentService.PaymentFee(updateQuota);
                
                contract.Installments.Add(new Installment(dueDate, fullQuota));
            }
        }
    }
}
