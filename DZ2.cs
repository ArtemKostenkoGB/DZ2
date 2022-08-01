using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            void Z10()
            {
               int number = 123; 
               Console.WriteLine(number);
               if (number > 99 && number < 1000)
               {
                    Console.WriteLine("вторая цифра:" + (number / 10 % 10));
               }

            }
            void Z13()
            {
                int number = 78;
                if(number < 100)
                {
                    Console.WriteLine("число двухзначное");
                }
                else
                {
                while (number > 999)
                {
                    number /= 10;
                }
                Console.WriteLine(number%10);
            }
            }

            void Z15()
            {
                int day = 6;
                if (day == 6 || day == 7)
                {
                    Console.WriteLine("выходной день");
                }
                else if (day >= 1 && day <= 5)
                {
                    Console.WriteLine("будний день");
                }
            }
            Z10();
            Z13();
            Z15();
        }
    }
}
