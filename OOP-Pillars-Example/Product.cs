using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars_Example
{
    //Encapsulation
    class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double CalculateDiscount(double discountPercentage)
        {
            return price * (1 - discountPercentage / 100);
        }

        public string GetName()
        {
            return name;
        }
    }


    //Abstraction
    abstract class PaymentMethod
    {
        public abstract void ProcessPayment(double amount);
    }

    class CreditCardPayment : PaymentMethod
    {
        private string cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public override void ProcessPayment(double amount)
        {
            // Process payment using the credit card
        }
    }

    //Inheritance
    class ShoppingCartItem
    {
        protected Product product;
        protected int quantity;
        public ShoppingCartItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        public virtual double CalculateTotalPrice()
        {
            return product.CalculateDiscount(0) * quantity;
        }
    }

    class DiscountedShoppingCartItem : ShoppingCartItem
    {
        private double discountPercentage;
        public DiscountedShoppingCartItem(Product product, int quantity, double discountPercentage)
            : base(product, quantity)
        {
            this.discountPercentage = discountPercentage;
        }
        public override double CalculateTotalPrice()
        {
            return product.CalculateDiscount(discountPercentage) * quantity;
        }
    }


    //Polymorphism
    class Order
    {
        private List<ShoppingCartItem> items;

        public Order()
        {
            items = new List<ShoppingCartItem>();
        }

        public void AddItem(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public double CalculateTotalOrderPrice()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.CalculateTotalPrice();
            }
            return total;
        }
    }


}
