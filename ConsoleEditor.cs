using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ConsoleEditor
    {
        public void runConsoleEditor(Editor editor)
        {
            Console.WriteLine("Welcome to the testing application.");
            String regOrNot = "";
            while (regOrNot != "1" && regOrNot != "2")
            {
                Console.WriteLine("Have an account? Press 1");
                Console.WriteLine("New one? Press 2");
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

            if (teacherOrNot == "1")
            {
                Console.WriteLine("Logged in as teacher.");
                editor.PrintAllTests();
                int option;
                bool toContinue = true;
                while (toContinue)
                {
                    Console.WriteLine("Options available:");
                    Console.WriteLine("1 - add test \n2 - delete test \n3 - edit test name \n4 - print all tests \n5 - edit test \n6 - log out");
                    Console.WriteLine("Choose option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            editor.AddTest();
                            break;
                        case 2:
                            editor.DeleteTest();
                            break;
                        case 3:
                            editor.EditTestName();
                            break;
                        case 4:
                            editor.PrintAllTests();
                            break;
                        case 5:
                            editor.EditTest();
                            break;
                        case 6:
                            toContinue = false;
                            runConsoleEditor(editor);
                            break;
                    }
                }
            }

            if (teacherOrNot == "2")
            {
                Console.WriteLine("Logged in as student.");
                editor.PrintAllTests();
                bool toContinue = true;
                int option;
                while (toContinue)
                {
                    Console.WriteLine("Options available:");
                    Console.WriteLine("1 - choose test \n2 - log out");
                    Console.WriteLine("Choose option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            editor.PrintAllTests();
                            Console.WriteLine("Choose number of test:");
                            editor.TestPassing(Convert.ToInt32(Console.ReadLine()) - 1);
                            break;
                        case 2:
                            toContinue = false;
                            runConsoleEditor(editor);
                            break;
                    }

                }

            }
        }
    }
}
