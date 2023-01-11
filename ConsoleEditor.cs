using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
	class ConsoleEditor
    {
        public void main()
        {
            int regOrAuth = -1;
            Console.WriteLine("© 2023. Programmer brigade.");
            Console.WriteLine("Welcome to the testing application.");
            while (regOrAuth != 0 && regOrAuth != 1)
            {
                Console.WriteLine("New one? Press 0");
                Console.WriteLine("Already have an account? Press 1");
                regOrAuth = Convert.ToInt32(Console.ReadLine());
                if (regOrAuth != 0 && regOrAuth != 1) Console.WriteLine("Invalid input. Please try again.");
            }
            
        }
    }
}
