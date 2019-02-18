using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter some numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of odd numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }

            Console.ReadLine();

            {
                Console.WriteLine("\n" + "The total of these numbers is : ");
                int sum = arr.Sum();
                Console.WriteLine(sum);
            }

            Console.ReadLine();

            {
                Console.WriteLine("Here's a string reversed : ");
                Console.WriteLine(StringHelper.ReverseString("Hello World!"));
            }

            Console.ReadLine();

            {
                string value1 = RemoveDuplicateChars("Google");
                Console.WriteLine("Here's Google without duplicate characters: " + value1);
            }

            string RemoveDuplicateChars(string key)
            {
                string result = "";

                foreach (char value in key)
                {
                    if (result.IndexOf(value) == -1)
                    {
                        result += value;
                    }
                }
                return result;
            }

            Console.ReadLine();

            {
                Console.WriteLine("Fizz Buzz!");

                Console.ReadLine();

                for (int j = 1; j <= 100; j++)
                {
                    if (j % 3 == 0 && j % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (j % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (j % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(j);
                    }
                }

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}