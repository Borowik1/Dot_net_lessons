using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MaxWithdrawCountException : BankException
    {
        public MaxWithdrawCountException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
