using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        public float CalculateTotalCost()
        {
            float totalCost = 0;
            foreach (var product in _products)
            {
                totalCost += product.CalculateTotalCost();
            }

            float shippingCost = _customer.LivesInUSA() ? 5.0f : 35.0f;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder("Packing Label:\n");
            foreach (var product in _products)
            {
                label.AppendLine(product.GetProductInfo());
            }
            return label.ToString();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
        }
    }
}
