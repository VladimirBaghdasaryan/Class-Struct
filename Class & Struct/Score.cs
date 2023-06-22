using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Struct
{
    internal class Score
    {
        public decimal AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Score(decimal accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }
        
        public void Withdraw(decimal withdraw)
        {
            Balance -= withdraw;
        }

        public void GetBalance()
        {
            Console.WriteLine("Ballance:" + Balance);
        }
    }
}
