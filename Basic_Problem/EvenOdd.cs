using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class EvenOdd
    {
        public int Num;

        public void Check ()
        {
            Console.WriteLine("Enter the  Number");
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
