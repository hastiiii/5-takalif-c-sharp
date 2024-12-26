using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taklif3
{
    class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای به زبان سی شارپ بنویسید که دو عدد از ورودی گرفته و جای ان ها را باهم عوض کند

            int a;
            int b;
            int temp;
            Console.Write("Enter the first number: ");
            string num = Console.ReadLine();
            a = Convert.ToInt32(num);
            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();
            b = Convert.ToInt32(num2);
            Console.WriteLine("before swapping a = " + a + " , b = " + b);

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = " + a + " , b = " + b);
            Console.ReadKey();
        }
    }
}
