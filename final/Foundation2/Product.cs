using System;

namespace OrderProcessingApp
{
    public class Product
    {
        private string _name;
        private string _productId;
        private float _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, float pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public float CalculateTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        public string GetProductInfo()
        {
            return $"{_name} (ID: {_productId})";
        }
    }
}
