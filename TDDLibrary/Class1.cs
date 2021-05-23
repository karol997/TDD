using System;

namespace TDD
{
    public class TDDLibrary
    {


        public static int max(int a, int b, int c)
        {
            int maximum = 0;
            if (a > b) maximum = a;
            if (a > c) maximum = a;
            if (a < b) maximum = b;
            if (a < c) maximum = c;
            if (b > c) maximum = b;
            if (c > b) maximum = c;
            return maximum;
        }

        public static void Main()
        {

        }
    }
}
