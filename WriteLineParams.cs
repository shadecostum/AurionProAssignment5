using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsWriteLine
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("---params used---");
            //params used array  syntatic sugar,it can dynamical values enter used function ,last of method write params 
            int[] array1 = { 10, 20, 30, 40 };
            arrayParams(array1);
            arrayParams();
            arrayParams(15, 25, 38, 65);
            //normal array syntaticaly time consume;
            Console.WriteLine("------end-------");


            Console.WriteLine("---WriteLine used---");
            PrintNumbers(1, 2, 3); // Pass three arguments
            PrintNumbers(); // Pass no arguments
            int[] nums = { 4, 5, 6 }; // Create an array of integers
            PrintNumbers(nums); // Pass an array as an argument
            Console.WriteLine("------end-------");

            writeLineExample();
        }
        static void PrintNumbers(params int[] numbers)
        {
            // Print the length of the array
            Console.WriteLine("The array has {0} elements.", numbers.Length);

            // Loop through the array and print each element
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}.", i, numbers[i]);
            }
        }

        static void writeLineExample()
        {
            int intValue = 42;
            double doubleValue = 3.14;
            string stringValue = "Hello, world!";
            bool boolValue = false;

            // Using Console.WriteLine() with a params array
            Console.WriteLine("Integer: {0}, Double: {1}, String: {2} ,Boolvalue:{3}", intValue, doubleValue, stringValue,boolValue);
        }

        //params mainly used it helps you to create dynamic input parameters
        //a single method can accept more variables to calculate
        private static void arrayParams(params int[] array1)
        {
            int sum = 0;
            foreach (int item in array1)
            {
                //Console.WriteLine("params used :"+item);
                sum = sum + item;



            }
            Console.WriteLine("result params:" + sum);
            Console.WriteLine("------");

        }


    }

}

