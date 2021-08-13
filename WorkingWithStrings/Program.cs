using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is using the special \ character with the " character on both sides of
             * the word / words that you wish to insert DOUBLE QUOTES within a literal string.

            string myString = "My \"so-called life...\"";

             This is using the special \ character with the n character to
             * insert a NEW LINE within a literal string.


            string myString = "What if I needed\n a new line?";

            This is using the special \ with the \ character to 
            insert a BACKSLASH within a literal string.

            string myString = "Go to your C:\\ drive."; 

            This is using the special @ symbol BEFORE starting the literal string, to tell the string that
            it's a LITERAL STRING and DO NOT DILINEATE it.

            string myString = @"This is so cool I guess. Please go to the C:\ drive of your PC";

            This is using String Format to make pretty code / sentences! Yay!

            string myString = String.Format("{0} = {1}", "First", "Second");


            This is some special super powers that String.Format can complete.
            It can have special codes that will place certain special characters
            into the string, depending on the code.
            
            CURRENCY:
            string myString = String.Format("{0:C}", 123.45); 

            TURN A STRING OF NUMBERS INTO ACTUAL NUMERICAL VALUE:
            string myString = String.Format("{0:N}", 1234567890); 

            PERCENTAGE:
            string myString = String.Format("Percentage: {0:P}", .123);

            // CUSTOM FORMATTING:
            string myString = String.Format("Phone Number: {0:(###) ###-####}", 1234567890); */

            //string myString = " That summer we took threes across the board  ";


            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, 
                myString.Trim().Length);



            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            } */



            // MAKE SURE TO USE STRINGBUILDER AS OFTEN AS POSSIBLE



            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
