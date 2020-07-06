using Facade.API;

namespace Facade
{
    public class OnlineShoppingFacade
    {
        private readonly IInventory inventory;
        private readonly IOrderVerify orderVerify;
        private readonly ICosting costManger;
        private readonly IPaymentGateway paymentGateWay;
        private readonly ILogistics logistics;

        public OnlineShoppingFacade()
        {
            this.inventory = new InventoryManager();
            this.orderVerify = new OrderVerificationManager();
            this.costManger = new CostManager();
            this.paymentGateWay = new PaymentGatewayManager();
            this.logistics = new LogisticsManager();
        }
        public void FinalizeOrder(OrderDetails orderDetails)
        {
            if (orderDetails == null)
            {
                return;
            }

            this.inventory.Update(orderDetails.ID);

            this.orderVerify.VerifyShippingAddress(orderDetails.PinCode);

            orderDetails.Price = costManger.ApplyDiscounts(orderDetails.Price, orderDetails.DiscountPercent);

            this.paymentGateWay.VerifyCardDetails(orderDetails.CardNo);

            this.paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);

            this.logistics.ShipProduct(orderDetails.ProductName, string.Format("{0}, {1} - {2}.",
                                  orderDetails.AddressLine1, orderDetails.AddressLine2,
                                  orderDetails.PinCode));
        }
    }
}
