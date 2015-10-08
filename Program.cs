using System;
using MyCouch;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //this give me this error:
            //System.IO.FileNotFoundException: Could not load file or assembly 'EnsureThat, Version=2.0.0.39118, Culture=neutral, PublicKeyToken=null' or one of its dependencies.
            //File name: 'EnsureThat, Version=2.0.0.39118, Culture=neutral, PublicKeyToken=null'
            var client = new MyCouchStore("http://localhost:5984/test");
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
