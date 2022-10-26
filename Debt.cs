using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debt
{
    public class Debt1
    {
        private double _intialBalance;
        private double _initialInterestRate;
        public Debt1(double intialBalance, double initialInterestRate)
        {
            _intialBalance = intialBalance;
            _initialInterestRate = initialInterestRate;
        }
        public void WaitOneWaitOneYear()
        {
            _intialBalance = _intialBalance * _initialInterestRate;
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Balance: {_intialBalance} InterestRate: {_initialInterestRate}");
        }

    }
}
