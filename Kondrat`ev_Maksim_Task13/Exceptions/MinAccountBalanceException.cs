using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MinAccountBalanceException : BankException
    {
        public MinAccountBalanceException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
