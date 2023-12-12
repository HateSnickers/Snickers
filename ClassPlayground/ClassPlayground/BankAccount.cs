using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public float AccountNumber;
        public float HolderName;
        public float Currency;
        public decimal Balance;

        public BankAccount(float AccountNumber, float HolderName, float Currency, decimal Balance)
        {
            AccountNumber = 0;
            HolderName = holderName;
            Currency = currency;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Vloženo {amount} {Currency} na účet č. {AccountNumber}. Nový zůstatek: {Balance} {Currency}");
            }
            else
            {
                Console.WriteLine("Množství peněz musí být kladné.");
            }
        }
    }
}
