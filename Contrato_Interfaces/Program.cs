using Contrato_Interfaces.Entities;
using Contrato_Interfaces.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Date (dd/mm/yyyy): ");
DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract Value: ");
double contractValue =  Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number of installments: ");
int installments =  Convert.ToInt32(Console.ReadLine());

Contract contract = new Contract(number, dateTime, contractValue);

ContractService contractService = new ContractService(new PayPalService());

contractService.ProcessContract(contract, installments);

Console.WriteLine();
Console.WriteLine("Installments: ");

foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}
