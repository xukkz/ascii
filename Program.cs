using System;

namespace ascii
{
    class Program
    {
        public static string input;
        public static int i1;
        public static char[,] array1 = new char[8, 15];
        static void Main()
        {
            // i1 = Convert.ToInt16(Console.ReadLine());

            input = Console.ReadLine();

            switch (input)
            {
                case "0000":
                    Console.WriteLine(input);
                    Console.ReadLine();
                    break;

                default:
                    Main();
                    break;
            }
        }
    }
}
