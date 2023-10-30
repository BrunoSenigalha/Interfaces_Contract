using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato_Interfaces.Services
{
    internal class PayPalService : IPaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MontlyInterest = 0.01;
        public double Interest(double amount, int mounths)
        {
            return amount * MontlyInterest * mounths;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
