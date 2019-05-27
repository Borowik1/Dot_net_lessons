using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MaxDepositException : BankException
    {
        public MaxDepositException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
