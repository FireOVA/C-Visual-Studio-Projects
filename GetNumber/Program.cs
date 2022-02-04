using System;

namespace GetNumber
{
    class Program
    {
        static bool getRandomNumber(out int x1)
        {
            Random rnd = new Random();
            int rNum = rnd.Next(100);

            if (rNum <= 5)
            {
                x1 = 0;
                return false;
            }
            x1 = rNum;
            return true;
        }
        
        static bool addFive(ref int y1)
        {
            int temp = y1 + 5;

            if (temp <= 5)
            {
                y1 = 0;
                return false;
            }
            y1 = temp;
            return true;
        }
        
        static void Main(string[] args)
        {
            int x;
            bool b1 = getRandomNumber(out x);

            int y = 5;
            bool b2 = addFive(ref y);
        }
    }
}
