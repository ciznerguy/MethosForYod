using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethosForYod
{
    internal class Program
    {
        public static void PrintFullName (string firstName, string lastName)
        {
            Console.WriteLine($" full name {firstName} {lastName}");
        }

        public static void PrintShape (int Length)
        {
            for (int  i = 0; i<Length;  i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
        public static void SumOfTwoNumbers(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of two numbers is: " + sum);
        }

        public static int SumOfTwoNumbersReturn(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int Sign(int num)
        {
            if (num > 0)
            {
                return 1;
            }
            else if (num < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool IsEven ( int num)
        {
            return num % 2 == 0;
        }

        public static void CheckNum(int n)
        {
            int sign =Sign(n); 
        }
        public static void Targill5047(int num)
        {
            if (num % 2 == 0)
            {
                for (int i = num; i < num + 10; i++)
                {
                    Console.Write(i+",");
                }
            }
            else
            {
                for (int i = num; i > num - 10; i--)
                {
                    Console.Write(i + ",");
                }
            }
        }


        // יש לכתוב פעולה המקבלת שני מספרים ומחזירה אמת אם
       //
       //הראשון גדול מהשני
        public static bool IsGreater(int num1, int num2)
        {
            return (num1 > num2);
            
           
        }
        public static void Targill5048(int num1)
        {
            int result = Fibonacci(num1);
            
                Console.WriteLine(result);
            

        }
        public static int Fibonacci(int num)
        {
            int first = 1;
            int second = 1;
            for (int i = 1; i < num-1; i++)
            {
                int temp = first;
                first = second;
                second = temp + second;

            }
            return second;
        }

            static void Main(string[] args)
        {
            Targill5048(6);
        }
           
    }
}
