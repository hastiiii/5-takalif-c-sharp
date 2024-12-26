using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taklif2
{
    class Program
    {
        static void Main(string[] args)
        {

            //برنامه ای به زبان سی شارپ بنویسید که یک عدد از ورودی گرفته اگر زوج بود ان را دو برابر و
            // اگر فرد بود ان را نصف حاصل را ذخیره و چاپ کند

            float userNo;
            string num;
            Console.Write("Enter a number :");
            num = Console.ReadLine();
            userNo = Convert.ToInt32(num);
            if (userNo % 2 == 0)
            {
                userNo = userNo * 2;
            }
            else
            {
                userNo = userNo / 2;
            }
            Console.WriteLine(userNo);
            Console.ReadKey();
        }
    }
}
