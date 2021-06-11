using System;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public class AutoLoan : LoanProcessTemplate
    {
        protected override void CollectInfo()
        {
            Console.WriteLine("Auto Loan Details are collected");
        }

        protected override void CreditAmount()
        {
            Console.WriteLine("Auto Loan Amount Credited");
        }

        protected override void DoVerification()
        {
            Console.WriteLine("Auto Loan Verificatin Is Done");
        }
    }

    public class HomeLoan : LoanProcessTemplate
    {
        protected override void CollectInfo()
        {
            Console.WriteLine("Home Loan Details are collected");
        }

        protected override void CreditAmount()
        {
            Console.WriteLine("Home Loan Amount Credited");
        }

        protected override void DoVerification()
        {
            Console.WriteLine("Home Loan Verificatin Is Done");
        }
    }

    public class PersonalLoan : LoanProcessTemplate
    {
        protected override void CollectInfo()
        {
            Console.WriteLine("Personal Loan Details are collected");
        }

        protected override void CreditAmount()
        {
            Console.WriteLine("Personal Loan Amount Credited");
        }

        protected override void DoVerification()
        {
            Console.WriteLine("Personal Loan Verificatin Is Done");
        }
    }

    public abstract class LoanProcessTemplate
    {
        public void ProcessLoan()
        {
            CollectInfo();
            DoVerification();
            CreditAmount();
        }

        protected abstract void CollectInfo();

        protected abstract void DoVerification();

        protected abstract void CreditAmount();
    }
}