using System;
using System.Collections.Generic;

namespace project{

    class Test{

        private List<Question> questionsArr = new List<Question>();
        private int resultOfTest;

        public Test (){
            System.Console.WriteLine("Test has been created.");
        }

        public List<Question> QuestionsArr{

            get{
                return this.questionsArr;
            }

            private set{
            }
            
        }

        public string ResultOfTest{

            get{
                return this.ResultOfTest;
            }

            private set{
            }
            
        }

        public void AddQuestionToTest(){
            Question QuestionInTest = new Question();
            System.Console.WriteLine("Write your question: ");
            QuestionInTest.QuestionText = Console.ReadLine();
            System.Console.WriteLine("Choose the mark for this question: ");
            QuestionInTest.Mark = Convert.ToInt32(Console.ReadLine());
            questionsArr.Add(QuestionInTest);
        }

        public void DeleteQuestionFromTest(){
            System.Console.WriteLine("Please choose the number of the question you want to delete: ");
            int num = Convert.ToInt32(Console.ReadLine());
            questionsArr.RemoveAt(num-1);
        }

        public void ChangePlaceInTest(){}

        public void EditQuestionInTest(){}


    }

}