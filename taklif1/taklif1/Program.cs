using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taklif1
{
    class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای به زبان سب شارپ بنویسید که که نمره شما را در پایان ترم از ورودی بگیرد و وضعیت درسی را مشخص کند

            float userPoint;
            string num;
            Console.Write("Enter your point: ");
            num = Console.ReadLine();
            userPoint = Convert.ToInt32(num);
            if (userPoint < 10)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
            Console.ReadKey();
        }
    }
}
