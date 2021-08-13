using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The following commented code is
             * the absolute WRONG way to make an array. It
             * is merely here for comparison and contrast.
             * 
             * int number1 = 4;
             * int number2 = 8;
             * int number3 = 15;
             * int number4 = 16;
             * int number5 = 23;
             * 
             * if (number1 == 16)
             * {
             * }
             * 
             * else if (number2 == 16)
             * {
             * }
             * else if (number3 == 16)
             * {
             * }
             * .... YEAH... that's the correct way to do it... if you want to mess your computer up super bad.
             * The following, uncommented code will be the proper array learning. */


            /* int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine(); */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            //string[] names = new string[] { "Eddie", "Thomas", "Franklin", "Bobby" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine(); */
            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine(); */



            // THIS will take a string, reverse everything and stuff. Fuckin awesome.


            string zig = "You can get what you want out of life" +
                " you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
