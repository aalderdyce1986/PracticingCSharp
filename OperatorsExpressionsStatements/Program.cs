using System;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int x, y, a, b;

            // Assignment Operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There are many mathematical operators...

            // Addition Operator
            x = 3 + 4;

            // Subtraction Operator
            x = 4 - 3;

            // Multiplication Operator
            x = 10 * 5;

            // Division Operator
            x = 10 / 5;

            // Order of Operations using Parentheses
            x = (x + y) * (a - b);

            // There are many operators used to evaluate values...

            // Equality Operator
            if (x == y)
            {

            }


            // Greater than Operator
            if (x > y)
            {

            }


            // Less than Operator
            if (x < y)
            {

            }


            // Greater than or Equal To Operator
            if (x >= y)
            {

            }


            // Lesser than or Equal To Operator
            if (x <= y)
            {

            }

            /* There are two "conditional" operators as well that can
             * be used to expand / enhance an evaluation...
             * ... and they can be combined together multiple times. */

            // Conditional AND Operator
            if ((x > y) && (a > b))
            {

            }

            // Conditional OR Operator
            if ((x > y) || (a > b))
            {

            }

            /* Also, there's the in-line conditional operator we
             * learned about while learing about IF statements.... */

            string message = (x == 1) ? "Car" : "Boat";

            /* Member Access and Method Invocation:
             * the "." in the code is the "Member Access", basically
             * it allows you to access all of the methods and various
             * other items that the class is using.
             * 
             * Method Invocation is () at the end of a method's name.
             * It is just what is used, what Microsoft decided to use for
             * the language. */

            Console.WriteLine("Hi");




        }
    }
}
