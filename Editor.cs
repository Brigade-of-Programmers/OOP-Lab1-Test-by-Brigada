using System;
using System.Collections.Generic;
using project;

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

            foreach (Test item in TestArr)
            {
                Console.WriteLine(item.NameOfTest);
            }
        }

        //public void chooseTest()
        //{
        //    Console.WriteLine("Choose the number of test: ");
        //    int index = Convert.ToInt32(Console.ReadLine());
        //    TestArr[index].startTest;
        //}

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
    }
}


