using System;
using System.Collections.Generic;

namespace project{

    public class Test{

        private List<Question> questionsArr = new List<Question>();
        private int resultOfTest;

        private string nameOfTest;

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

        public int ResultOfTest{

            get{
                return this.resultOfTest;
            }

            private set{
            }
            
        }

        public string NameOfTest{

            get{
                return this.nameOfTest;
            }

            set{
                this.nameOfTest = value;
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

        public void ChangePlaceInTest(){
            System.Console.WriteLine("Choose the number of the question which place you want to change: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Choose the number of the second question which place the first question will be changed with: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Question temp = QuestionsArr[num1-1];
            QuestionsArr[num1-1] = QuestionsArr[num2-1];
            QuestionsArr[num2-1] = temp;
        }

        public void EditQuestionInTest(){

            System.Console.WriteLine("Which question you want to change: ");
            int numOfQ = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Do you want to change the text of the question? 1 - yes, 2 - no");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 1){
                System.Console.WriteLine("Write your question: ");
                QuestionsArr[numOfQ-1].QuestionText = Console.ReadLine();
            }
            System.Console.WriteLine("Do you want to change the type of the question? 1 - yes, 2 - no");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 1){
                System.Console.WriteLine("Nothing is changed because types of questions do not exist.");
            }
            System.Console.WriteLine("Do you want to change the mark for the question? 1 - yes, 2 - no");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == 1){
                System.Console.WriteLine("Choose the mark for this question: ");
                QuestionsArr[numOfQ-1].Mark = Convert.ToInt32(Console.ReadLine());
            }
        }

    }

}