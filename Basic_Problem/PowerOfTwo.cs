using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class PowerOfTwo
    {
        public int A, B, Num;

        public void Poweroftwice ()
        {
            Console.WriteLine("Enter Any Number");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Power you want to Required");
            A = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {
                Num = Convert.ToInt32(Math.Pow(B, A));
            }
            Console.WriteLine("you Entered Power of Number is : " + Num);
        }
    }
}
