using System;

namespace Lab0
{
    internal class Numbers
    {
        double lownum2;
        double highnum2;
        public double Get_low()
        {
            //int lownum2 = 0;

            Console.Write("Enter low number: ");
            lownum2 = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine("Enter low number:");
            //lownum2 = Convert.ToDouble(Console.ReadLine());

            while (lownum2 < 0 | lownum2 >= 20)
            {
                Console.Write("Enter a lower positive number: ");
                lownum2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Low number is: " + lownum2);
            Console.ReadLine();
            return lownum2;


        }
        public double Get_high()
        {
            //int highnum2 = 0;
            Console.Write("Enter high number: ");
            highnum2 = Convert.ToDouble(Console.ReadLine());
            while (lownum2 > highnum2)
            {
                Console.Write("Enter a higher number: ");
                highnum2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("High number is: " + highnum2);
            Console.ReadLine();
            return highnum2;
        }
    }
}
