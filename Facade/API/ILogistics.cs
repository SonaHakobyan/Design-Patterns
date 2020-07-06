using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.API
{
    interface ILogistics
    {
        void ShipProduct(string productName, string shippingAddress);
    }
}
