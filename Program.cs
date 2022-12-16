using System;
using System.Collections.Generic;
using System.Text;

    class Leapyear
    {
        private static bool Check(int y)
        {
            return (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0)) ? true : false;
        }
        public static void Main()
        {
            int year;
            Console.Write("년도를 입력하시오:");
            year = int.Parse(Console.ReadLine());
            if (Check(year))
                Console.WriteLine(year + "년도는 윤년입니다.");
            else
                Console.WriteLine(year + "년도는 평년입니다");
        }
    }