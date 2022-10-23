using System;
using System.Collections.Generic;

namespace project{

    class Test{

        private List<Question> questionsArr = new List<Question>();
        private int resultOfTest;

        public Test (){
            System.Console.WriteLine("Test has been created.");
        }

        public void AddQuestionToTest(){
            Question QuestionInTest = new Question();
            System.Console.WriteLine("Write your question: ");
            QuestionInTest.QuestionText = Console.ReadLine();
            System.Console.WriteLine("Choose the mark for this question: ");
            QuestionInTest.Mark = Console.Readline();
            questionsArr.Add(QuestionInTest);
        }

        public void DeleteQuestionFromTest(){}

        public void ChangePlaceInTest(){}

        public void EditQuestionInTest(){}


    }

}