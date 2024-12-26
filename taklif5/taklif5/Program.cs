using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taklif5
{
    class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای به زبان  سی شارپ بنویسید که یک عدد از کاربر گرفته از یک تا ان عدد را پشت سر هم چاپ کند   

            int userNo;
            Console.Write("Enter a number : ");
            string num = Console.ReadLine();
            userNo = Convert.ToInt32(num);

            for (int i = 1; i <= userNo; i++)
            {
                Console.Write(i+" ");

            }
            Console.ReadKey();
        }
    }
}
