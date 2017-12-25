using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Proxy
{
    public interface IPayment
    {
        string PayFund(float amount);
    }

    public class Payment : IPayment
    {
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public DateTime DateTime { get; set; }

        public string PayFund(float amount)
        {
            Console.WriteLine("\n\n BankName : {0} \n AccountNumber : {1} \n Amount : {2}", BankName, AccountNumber, amount);

            return Guid.NewGuid().ToString("N");
        }
    }

    public class CheckProxy : IPayment
    {

        Payment payment = new Payment();
        private bool isSignVerified = false;

        public CheckProxy(string bankName, int accountNumber, DateTime dateTime)
        {
            payment.BankName = bankName;
            payment.AccountNumber = accountNumber;
            payment.DateTime = dateTime;
            isSignVerified = true;
        }

        public string PayFund(float amount)
        {
            string receipt = string.Empty;
            if (isSignVerified)
            {
                receipt = payment.PayFund(amount);
            }

            return receipt;
        }
    }

    public class OnlinePaymentProxy : IPayment
    {

        Payment payment = new Payment();
        bool isValidAccount = false;

        public OnlinePaymentProxy(string bankName, int accountNumber, DateTime dateTime)
        {
            payment.BankName = bankName;
            payment.AccountNumber = accountNumber;
            payment.DateTime = dateTime;
            isValidAccount = true;

        }

        public string PayFund(float amount)
        {
            string reciept = string.Empty;

            if (isValidAccount)
            {
                reciept = payment.PayFund(amount);
            }
            return reciept;
        }
    }

}
