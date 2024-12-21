using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProject
{
    public class OnlineShoppingFacade
    {
        private ProductCatalog _productCatalog;
        private OrderSystem _orderSystem;
        private PaymentSystem _paymentSystem;

        public OnlineShoppingFacade()
        {
            _productCatalog = new ProductCatalog();
            _orderSystem = new OrderSystem();
            _paymentSystem = new PaymentSystem();
        }

        public void PurchaseProduct()
        {
            _productCatalog.GetProducts();
            _orderSystem.PlaceOrder();
            _paymentSystem.ProcessPayment();
            Console.WriteLine("Product Purchased Successfully!");
        }
    }
}
