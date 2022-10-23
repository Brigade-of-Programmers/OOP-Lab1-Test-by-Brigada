using System;

namespace project{

    class Program{
        
        static void Main(){
            
            Test test1 = new Test();
            test1.AddQuestionToTest();
            test1.AddQuestionToTest();
            test1.AddQuestionToTest();
            test1.DeleteQuestionFromTest();
            for(int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(test1[i] + i + " / ");
            }
        }

    }

}