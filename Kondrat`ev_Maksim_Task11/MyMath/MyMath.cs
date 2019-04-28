using System;

namespace MyMath
{
    public class Factorial
    {
        public static int GetFactorial(int basis)
        {
            int factorial = 1;
            for (int i = 1; i <= basis; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

    public class Exp
    {
        public static int GetExp(int basis, int power)
        {
            int multiplier = basis;
            for (int i = 1; i < power; i++)
            {
                basis *= multiplier;
            }
            return basis;
        }

    }

}