using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ConsoleEditor
    {
        public void runConsoleEditor()
        {
            Console.WriteLine("Welcome to the testing application.");
            String regOrNot = "";
            while (regOrNot != "1" && regOrNot != "2")
            {
                Console.WriteLine("New one? Press 2");
                Console.WriteLine("Have an account? Press 1");
                regOrNot = Console.ReadLine();
                if (regOrNot != "1" && regOrNot != "2") Console.WriteLine("Invalid input. Try again.");
            }

            Authorization auth = new Authorization();
            auth.Login(regOrNot);

            String teacherOrNot = "";
            while (teacherOrNot != "1" && teacherOrNot != "2")
            {
                Console.WriteLine("Teacher? Press 1");
                Console.WriteLine("Student? Press 2");
                teacherOrNot = Console.ReadLine();
                if (teacherOrNot != "1" && teacherOrNot != "2") Console.WriteLine("Invalid input. Try again.");
            }
            Editor editor = new Editor();
            if (teacherOrNot == "1")
            {
                Console.WriteLine("Logged in as teacher.");
                editor.printAllTests();
                int option;
                bool toContinue = true;
                while (toContinue)
                {
                    Console.WriteLine("Options available:");
                    Console.WriteLine("1 - add test \n2 - delete test \n3 - edit test name \n4 - print all tests \n5 - edit test \n6 - finish");
                    Console.WriteLine("Choose option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            editor.addTest();
                            break;
                        case 2:
                            editor.deleteTest();
                            break;
                        case 3:
                            editor.editTestName();
                            break;
                        case 4:
                            editor.printAllTests();
                            break;
                        case 5:
                            editor.editTest();
                            break;
                        case 6:
                            toContinue = false;
                            break;
                    }
                }
            }
        }
    }
}
