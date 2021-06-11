using System;

namespace DemoApp.Patterns.Structural.Decorator
{
    public interface IOrderPayment
    {
        double GetPrice();
    }

    public class OrderPayment : IOrderPayment
    {
        public string OrderName { get; set; }
        public int Price { get; set; }

        public double GetPrice()
        {
            // With 10% tax
            var tax = (Price * 0.1);
            var priceWithTax = tax + Price;

            Console.WriteLine($"10% Tax ${tax} is applied on your order ${Price} and the price is ${priceWithTax}");

            return priceWithTax;
        }
    }

    public abstract class PaymentDecorator : IOrderPayment
    {
        protected readonly IOrderPayment orderPayment;

        public PaymentDecorator(IOrderPayment orderPayment)
        {
            this.orderPayment = orderPayment;
        }

        public abstract double GetPrice();
    }

    public class ApplyCouponCode : PaymentDecorator
    {
        public int CouponPrice { get; set; }

        private double _price;

        public ApplyCouponCode(IOrderPayment orderPayment) : base(orderPayment)
        {
            _price = orderPayment.GetPrice();
        }

        public override double GetPrice()
        {
            var price = _price - CouponPrice;

            Console.WriteLine($"Coupon ${CouponPrice} is applied on your order and the price is ${price}");

            return price;
        }
    }

    public class ApplyRedCard : PaymentDecorator
    {
        public int RedCardPrice { get; set; }

        private double _price;

        public ApplyRedCard(IOrderPayment orderPayment) : base(orderPayment)
        {
            _price = orderPayment.GetPrice();
        }

        public override double GetPrice()
        {
            var price = _price - RedCardPrice;

            Console.WriteLine($"Red Card Price ${RedCardPrice} is applied on your order and the price is ${price}");

            return price;
        }
    }
}