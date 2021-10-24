using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class Harmonic
    {
        public int Num;
        public float Sum = 1;

        public void HarmonicNo()
        {
            Console.WriteLine("Enter  any Harmonic Number");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num != 0 && Num > 0)
            {
                for (float i = 2; i <= Num; i++)
                {
                    Sum += 1 / i;
                }
                Console.WriteLine("your Harmonic Value is: " + Sum);
            }
            else
            {
                Console.WriteLine("Enter your Harmonic Number ia always gratter than Zero");
            }
        }

    }
}
