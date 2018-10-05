using System;

namespace CS61
{
    public struct Money
    {
        public Money(decimal amount, string currency) : this()
        {
            Currency = currency;
            Amount = amount;
        }
        
        public string Currency { get; private set; }
        public decimal Amount { get; private set; } 
    }
}
