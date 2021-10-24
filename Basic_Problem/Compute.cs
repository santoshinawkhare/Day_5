using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class Compute
    {
        public int Num, Div, Quotient, Rem;

        public void computeNo ()
        {
            Console.WriteLine("Enter the number you want to divide");
            Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            Div = Convert.ToInt32(Console.ReadLine());
            Quotient = Num / Div;
            Rem = Num % Div;
            Console.WriteLine("Quotient is: " + Quotient);
            Console.WriteLine("Remainder is: " + Rem);
        }
    }
}
