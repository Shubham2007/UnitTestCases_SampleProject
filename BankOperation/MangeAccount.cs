using System;
using System.Collections.Generic;
using System.Text;

namespace BankOperation
{
    public class MangeAccount
    {
        private readonly string _customerName;
        private double _balance = 100;

        public static string msg = string.Empty;

        public MangeAccount(string customerName, double availableBalance)
        {
            this._customerName = customerName;
            this._balance = availableBalance;
        }

        public double GetBalance()
        {
            return this._balance;
        }

        public void Debit(double debitAmount)
        {
            try
            {
                if (debitAmount < 0)
                    throw new InvalidOperationException("amount cannot be less than 0");

                if (debitAmount > _balance)
                    throw new ArgumentOutOfRangeException("amount cannot exceed than available balance");

                _balance -= debitAmount;
            }
            catch(Exception ex)
            {
                msg = "excpetion occured.";
            }
        }

        public void Credit(double creditAmount)
        {
            try
            {
                if (creditAmount < 0)
                    throw new InvalidOperationException("amount cannot be less than 0");

                _balance += creditAmount;
            }
            catch (Exception ex)
            {
                msg = "excpetion occured.";
            }
        }

        private double AmountWithTax(double amount)
        {
            //TAX - Add 10% of amount
            double amountWithTax = amount + ((10 / 100) * amount);
            return amountWithTax;
        }
    }
}
