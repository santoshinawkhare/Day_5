using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class Factor
    {
        public int Num;

        public void PrimeFactor()
        {
            Console.WriteLine("Enter The Number To Find the Prime Factors");
            Num = Convert.ToInt32(Console.ReadLine());

            while (Num % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                Num = Num / 2;
            }
            for (int i = 3; i <= Math.Sqrt(Num); i += 2)
            {
                while (Num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    Num = Num / i;
                }
            }

            if (Num > 2)
            {
                Console.WriteLine(Num + "  ");
            }
        }
    }
}
