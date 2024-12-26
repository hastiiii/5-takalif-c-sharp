using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taklif4
{
    class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای به زیان سی شارپ بنویسید که سه عدد از ورودی بگیرد و 
            // مانند یک ماشین حساب به ترتیب ورود اعداد یک عدد سه رقمی چاپ کند

            int a;
            int b;
            int c;
            int res;
            Console.Write("Enter first number : ");
            string num1 = Console.ReadLine();
            a = Convert.ToInt32(num1);
            Console.Write("Enter second number : ");
            string num2 = Console.ReadLine();
            b = Convert.ToInt32(num2);
            Console.Write("Enter third number : ");
            string num3 = Console.ReadLine();
            c = Convert.ToInt32(num3);
            res = a * 100 + b * 10 + c;
            Console.WriteLine("Result numbers : " + res);
            Console.ReadKey();
        }
    }
}
