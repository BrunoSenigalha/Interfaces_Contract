using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato_Interfaces.Services
{
    internal interface IPaymentService
    {   
        public double PaymentFee(double amount);
        public double Interest (double amount, int mounths);
    }
}
