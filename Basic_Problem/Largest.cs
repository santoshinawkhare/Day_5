using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class Largest
    {
        public int a, b, c;

        public void MaxNo ()
        {
            Console.WriteLine("Please enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the  second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the  third number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b > c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }

        }
    }
}
