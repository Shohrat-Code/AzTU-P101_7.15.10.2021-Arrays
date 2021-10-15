using System;

namespace Algorithms_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        //break;
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //byte[] ages = new byte[5];
            //ages[0] = 25;
            //ages[1] = 20;
            //ages[2] = 32;
            //ages[3] = 47;
            //ages[4] = 62;

            byte[] ages = { 12, 4, 74 };

            Array.Resize(ref ages, ages.Length + 1);
            ages[ages.Length - 1] = 25;

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }
    }
}
