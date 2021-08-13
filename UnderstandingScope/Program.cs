using System;

namespace UnderstandingScope
{
    class Program
    {
        /*
         Public and Private are access availabilities. Public can be used by
         entire Program within Scope... but Private is used for the Under The
         Hood, it isn't used by anyone outside of the access.
         
         Basically, what I'm saying is: 
         
         Public = anyone has access to
         Private = only inside of the method gets
         
         */

        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);

            }
            //Console.WriteLine(i);
            Console.WriteLine("This is outside of the For Loop: " + j);
            Console.WriteLine("This is using private string k: " + k);

            HelperMethod();

            Car myCar = new Car();

            myCar.DoSomething();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of K from the HelperMethod(): " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello, World!! I have returned!";
        }
    }
}
