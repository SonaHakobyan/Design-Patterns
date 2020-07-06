using System;

namespace Facade.API
{
    public class PaymentGatewayManager : IPaymentGateway
    {
        public bool VerifyCardDetails(string cardNo)
        {
            Console.WriteLine($"Card #{cardNo} has been verified and is accepted.");
            return true;
        }

        public bool ProcessPayment(string cardNo, float cost)
        {
            Console.WriteLine($"Card# {cardNo} is used to make a payment of {cost}.");
            return true;
        }
    }
}
