using System;

namespace ascii
{
    class Program
    {
        public static string test;
        public static string input;
        public static string result;
        public static string calculateBinary(string x)
        {
            test = x;
            result = Convert.ToString(Convert.ToInt32(test, 2), 10);

            return result;
        }


        public static string[,] array2Db = new string[16, 2]
        {
            { "one", "two" },
            { "three", "four" },
            { "five", "six" },
            {"seven", "eight"},
            {"nine", "ten"},
            {"eleven", "twelve"},
            {"thirteen", "fourteen"},
            {"fiftheen", "sixteen"},
            {"seventeen", "eighteen"},
            {"nineteen", "twenty"},
            {"twnetyone", "twentytwo"},
            {"twentithreee", "twentifouur"},
            {"tentifife", "twentisex"},
            {"twentiseven", "twentinine"},
            {"twentiten", "twnetieleven"},
            {"twentitweleve", "twentithireetn"}
        };

        static void Main()
        {
            input = Console.ReadLine();

            Console.WriteLine(calculateBinary(input));
            Console.ReadLine();
            Main();
        }
    }
}
