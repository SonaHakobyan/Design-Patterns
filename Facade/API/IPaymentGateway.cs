namespace Facade.API
{
    interface IPaymentGateway
    {
        bool VerifyCardDetails(string cardNo);
        bool ProcessPayment(string cardNo, float cost);
    }
}
