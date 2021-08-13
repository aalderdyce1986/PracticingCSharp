using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variable is a bucket that puts values in and takes
             * values out. Can be of any data type. */

            /* int x = 7;
           int y = x + 3;

           Console.WriteLine(y);
           Console.ReadLine(); */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();


            /* string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine(); */

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("\n\nHello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();

            /* When you name your variables, make sure that they are meaningful, descriptive.
             * Use camel casing as well:   myLuckyNumber    <--- is an example of camel casing.
             * Camel casing is just the first word lowercase, the first letter of the next word and
             * all other subsequent words shall be uppercase. ALSO A BIG NOTE: If you wrote myLuckyNumber
             * for a variable, and then write myluckynumber to call the variable. HOWEVER it won't work, 
             * because it is considered a different variable.  ALSO: You cannot name two variables the
             * same name in the same scope. 
             
             1) Give variables meaningful and descriptive name using camel casing
             2) Initialize the variable (state its value) immediately after declaration.*/


        }
    }
}
