using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "A class is the most powerful data type in C#. Like a structure," +
            //"a class defines the data and behavior of the data type. ";

            

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://google.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\aaron\source\repos\AssembliesAndNamespaces\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
