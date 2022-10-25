using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace TestingApp
{
     public class Program
     {
        static void Main()
        {
            
            Authorization auth = new Authorization();

            Console.WriteLine("For authorization, enter 1, for registration, enter 2");
            var input = Console.ReadLine();
            auth.Login(input);
        }
     }
}