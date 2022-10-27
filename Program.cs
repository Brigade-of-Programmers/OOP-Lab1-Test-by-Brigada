using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace project
{
    public class Program
    {
        static void Main()
        {

            Authorization auth = new Authorization();

            Console.WriteLine("For authorization, enter 1, for registration, enter 2");
            var input = Console.ReadLine();
            auth.Login(input);

            Test test1 = new Test("Test1");
            test1.AddQuestionToTest();
            test1.AddQuestionToTest();
            test1.AddQuestionToTest();
            for (int i = 0; i < test1.QuestionsArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". Q:" + test1.QuestionsArr[i].QuestionText + " M:" + test1.QuestionsArr[i].Mark + " \n ");
            }
            test1.ChangePlaceInTest();
            for (int i = 0; i < test1.QuestionsArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". Q:" + test1.QuestionsArr[i].QuestionText + " M:" + test1.QuestionsArr[i].Mark + " \n ");
            }
            test1.EditQuestionInTest();
            for (int i = 0; i < test1.QuestionsArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". Q:" + test1.QuestionsArr[i].QuestionText + " M:" + test1.QuestionsArr[i].Mark + " \n ");
            }

            Editor editor = new Editor();
            for (int i = 0; i < 3; i++)
            {
                editor.addTest();
            }
            editor.printAllTests();
            editor.deleteTest();
            editor.printAllTests();
            editor.editTestName();
            editor.printAllTests();
        }
    }
}