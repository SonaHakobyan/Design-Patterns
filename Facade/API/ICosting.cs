namespace Facade.API
{
    interface ICosting
    {
        float ApplyDiscounts(float price, float discountPercent);
    }
}
