//hello-name
//prints hello and user name on separate lines in c#

using System;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input your name here: ");
            
            var input = Console.ReadLine();
            
            Console.WriteLine("Hello\n" + input);
        }
    }
}
