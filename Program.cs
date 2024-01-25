using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call low and high functions
            Numbers obj1 = new Numbers();
            double lownum = obj1.Get_low();
            double highnum = obj1.Get_high();

            double difference; // Create variable for difference between high and low

            difference = highnum - lownum;

            Console.WriteLine($"{highnum} - {lownum} = {difference}");
            Console.ReadLine();

            // Specify the filepath
            string filepath = @"C:\Users\tcrow\Documents\Semester Two\OOP -CPRG-211\Programs\Lab0\Lab0\numbers.txt";

            // Task 3: Using Arrays and File I/O
            double[] numbersArray = CreateNumbersArray(lownum, highnum);


            // Create a list to store the lines
            List<double> numbersList = numbersArray.ToList();

            // Call method to write to text file
            WriteNumbersListToFile(numbersList, filepath);

            // Print list to the screen
            //foreach (var number in numbersList)
                //Console.WriteLine(number);
            //Console.ReadLine();


            // Read from file and sum
            double sum = 0;
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                sum += double.Parse(line);
            }
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine();

            // Prime Numbers
            Console.WriteLine($"Prime Numbers between {lownum} and {highnum}:");

            double primenum = 0; // Variable to store numbers for prime number verification
            foreach (string line in lines)
            {
                primenum = double.Parse(line); // Convert to double and store in variable
                if (IsPrime(primenum))
                {
                    Console.WriteLine(primenum);
                }
                else
                {
                    continue;
                }

            }

            Console.ReadLine();
        }


        static double[] CreateNumbersArray(double low, double high)
        {
            double newhigh = high - 1;
            double[] numbersArray = new double[(int)(high - low - 1)];
            for (double i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[(int)i] = newhigh--;
            }
            return numbersArray;
        }

        static bool IsPrime(double number) // Consulted Stack Overflow
        {
            {

                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;

            }
        }

        static void WriteNumbersListToFile(List<double> numbersList, string fileName)
        {
            List<string> stringList = numbersList.ConvertAll(d => d.ToString());
            File.WriteAllLines(fileName, stringList);
            Console.WriteLine($"Saved successfully to {fileName}");
            Console.WriteLine();
        }
    }
}


