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
            auth.Login();
            // todo: registration
        }
     }
}