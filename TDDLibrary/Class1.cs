using System;

namespace TDD
{
    public class TDDLibrary
    {
        public static int liczba_max_a;
        public static int liczba_max_b;
        public static int liczba_max_c;
        public static int maxa;

        public static int liczba_min_a;
        public static int liczba_min_b;
        public static int liczba_min_c;
        public static int mina;
        public static int boola;
        public static bool Test;

        public static int max(int a, int b, int c)
        {
            int maximum = 0;
            int value_max = 0;
            if (a > b) maximum = a;
            if (a > c) maximum = a;
            if (a < b) maximum = b;
            if (a < c) maximum = c;
            if (b > c) maximum = b;
            if (c > b) maximum = c;
            value_max = value_max + maximum;
            maxa = value_max;
            return maximum;
        }

        public static int min(int a, int b, int c)
        {
            int minimum = 0;
            int value_min = 0;
            if ((a < b) && (a < c)) minimum = a;
            if ((b < a) && (b < c)) minimum = b;
            if ((c < a) && (c < b)) minimum = c;
            value_min = value_min + minimum;
            mina = value_min;
            return minimum;
        }

        public static bool isPositive(int a)
        {
            if (a > 0)
                return Test = true;
            else
                return Test = false;
        }


        public static void Main()
        {
            max(liczba_max_a, liczba_max_b, liczba_max_c);
            min(liczba_min_a, liczba_min_b, liczba_min_c);
            isPositive(boola);
        }
    }
}
