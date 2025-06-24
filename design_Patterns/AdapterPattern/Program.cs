using System;

namespace AdapterPatternExample
{
    public interface IMYPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    public class PayPal
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"[PayPal] Payment of ${amount} completed.");
        }
    }
    public class GooglePay
    {
        public void ExcecuteTransaction(float amount)
        {
            Console.WriteLine($"[Gpay] Transaction of ${amount} Processed.");
        }
    }
    public class PayPalAdapter : IMYPaymentProcessor
    {
        private readonly PayPal _paypal;

        public PayPalAdapter()
        {
            _paypal = new PayPal();
        }
        public void ProcessPayment(decimal amount)
        {
            _paypal.MakePayment((double)amount);
        }
    }
    public class GooglePayAdapter : IMYPaymentProcessor
    {
        private readonly GooglePay _Gpay;

        public GooglePayAdapter()
        {
            _Gpay = new GooglePay();
        }
        public void ProcessPayment(decimal amount)
        {
            _Gpay.ExcecuteTransaction((float)amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern Example");

            IMYPaymentProcessor payPal = new PayPalAdapter();
            payPal.ProcessPayment(1500.00m);

            IMYPaymentProcessor gpay = new GooglePayAdapter();
            gpay.ProcessPayment(899.99m);
        }
    }
}