using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    public class Editor
    {
        private List<Test> testArr = new List<Test>();

        public List<Test> TestArr
        {
            get
            {
                return this.testArr;
            }
        }

        public void printAllTests()
        {
            Console.WriteLine("List of all tests: ");
            if (TestArr.Count == 0) Console.WriteLine("No tests have been created yet.");
            foreach (Test item in TestArr)
            {
                Console.WriteLine(item.NameOfTest);
            }
        }

          public void TestPassing(int index)
        {
            for(int i = 0; i < TestArr[index].QuestionsArr.Count(); i ++)
            {
                System.Console.WriteLine((i+1) + ". " + TestArr[index].QuestionsArr[i].QuestionText);;
                TestArr[index].QuestionsArr[i].ShowVariants();
                System.Console.WriteLine("Write your answer: ");
                string answer = Console.ReadLine();
                TestArr[index].QuestionsArr[i].GetUserAnswer(answer);
                TestArr[index].QuestionsArr[i].MarkOfQuestion();
            }

            for (int i = 0; i < TestArr[index].QuestionsArr.Count; i ++)
            {
                TestArr[index].ResultOfTest += TestArr[index].QuestionsArr[i].Mark;
            }
        }

        public int chooseTest()
        {
            Console.WriteLine("Choose the number of test: ");
            int index = Convert.ToInt32(Console.ReadLine());
            return index;
        }

        public void addTest()
        {
            Console.WriteLine("Choose test name: ");
            string name = Console.ReadLine();
            Test test = new Test(name);
            TestArr.Add(test);
        }

        public void deleteTest()
        {
            Console.WriteLine("Choose the number of the test you want to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());
            TestArr.RemoveAt(index - 1);
        }

        public void editTestName()
        {
            Console.WriteLine("Choose the number of the test you want to edit: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose new test name: ");
            string name = Console.ReadLine();

            TestArr[index - 1].NameOfTest = name;
        }

        public void editTest()
        {
            Console.WriteLine("Choose the number of the test you want to edit: ");
            int index = Convert.ToInt32(Console.ReadLine());

            bool toContinue = true;
            while (toContinue)
            {
                Console.WriteLine("Options available: ");
                Console.WriteLine("1 - add question to test \n2 - delete question from test \n3 - change place in test \n4 - edit question in test \n5 - finish editing");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        TestArr[index - 1].AddQuestionToTest();
                        break;
                    case 2:
                        TestArr[index - 1].DeleteQuestionFromTest();
                        break;
                    case 3:
                        TestArr[index - 1].ChangePlaceInTest();
                        break;
                    case 4:
                        TestArr[index - 1].EditQuestionInTest();
                        break;
                    case 5:
                        toContinue = false;
                        break;
                }
            }
        }
    }
}


