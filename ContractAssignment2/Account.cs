using System;
using System.Diagnostics.Contracts;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractAssignment2
{
    static class Account
    {
        private static double balance = 40.0;

        public static void SetBalance(double value)
        {
            balance = value;
        }

        public static void Deposit(double amount)
        {
            Contract.Requires<Exception>(amount>0);
            SetBalance(balance + amount);
        }

        static void Withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Requires<Exception>(balance > amount);
            SetBalance(balance - amount);
        }
        static void Main()
        {
            Console.WriteLine("Hey again");
            Deposit(20);
            try
            {
                Withdraw(80.0);
            }
            catch(Exception ex)
            {
                SetBalance(balance);
                Console.WriteLine("Exception caught "+ ex.Message);
            }
            Withdraw(5);
            Console.WriteLine(balance);
        }
    }
}
