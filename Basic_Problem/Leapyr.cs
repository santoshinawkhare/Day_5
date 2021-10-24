using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class Leapyr
    {
        public int Year;

        public void LeapYear()
        {
            Console.WriteLine("Enter a Year YYYY ");
            Year = Convert.ToInt32(Console.ReadLine());
            if (Year >= 1000 && Year < 10000)
            {
                if (Year % 4 == 0)
                {
                    Console.WriteLine("It's a Leap Year");
                }
                else if (Year % 400 == 0)
                {
                    Console.WriteLine("It's a Leap Year");
                }
                else if (Year % 100 == 0)
                {
                    Console.WriteLine("It's Not a Leap Year");
                }
                else
                {
                    Console.WriteLine("It's Not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Enter only Number");
            }
        }
    }
}
