using System;
using System.Collections.Generic;

namespace project
{
    public class Test
    {

        private List<Question> questionsArr = new List<Question>();
        private int resultOfTest;

        private string nameOfTest;

        public Test(string nameOfTest)
        {
            System.Console.WriteLine("Test <<" + nameOfTest + ">> has been created.");
            NameOfTest = nameOfTest;
        }

        public List<Question> QuestionsArr
        {

            get
            {
                return this.questionsArr;
            }

            private set
            {
            }

        }

        public int ResultOfTest
        {

            get
            {
                return this.resultOfTest;
            }

            private set
            {
            }

        }

        public string NameOfTest
        {

            get
            {
                return this.nameOfTest;
            }

            set
            {
                this.nameOfTest = value;
            }

        }

        public void AddQuestionToTest()
        {
            System.Console.WriteLine("Choose the type for this question: /nText answer question;/n2. One right variant question;/n3. Some right variants question;/n4. Conformity question;/n5. No right answer question;/n 6. Scale question;");
            string type = Console.ReadLine();
            Question QuestionInTest;
            switch (type)
            {
                case "1":
                    QuestionInTest = new DetailedAnswer();   
                    break;
                case "2":
                    QuestionInTest = new OneRightVariantQuestion();
                    break;
                case "3":
                    QuestionInTest = new SomeRightVariantsQuestion();
                    break;
                case "4":
                    QuestionInTest = new ConformityQuestion();
                    break;
                case "5":
                    QuestionInTest = new NoRightVariantQuestion();
                    break;
                case "6":
                    QuestionInTest = new ScaleQuestion();
                    break;
                default:
                    QuestionInTest = new DetailedAnswer();  
                    break;
            }
            QuestionsArr.Add(QuestionInTest);
            System.Console.WriteLine("Write your question: ");
            QuestionInTest.QuestionText = Console.ReadLine();
            System.Console.WriteLine("Choose the mark for this question: ");
            QuestionInTest.Mark = Convert.ToInt32(Console.ReadLine());
            questionsArr.Add(QuestionInTest);
        }

        public void DeleteQuestionFromTest()
        {
            System.Console.WriteLine("Please choose the number of the question you want to delete: ");
            int num = Convert.ToInt32(Console.ReadLine());
            questionsArr.RemoveAt(num - 1);
        }

        public void ChangePlaceInTest()
        {
            System.Console.WriteLine("Choose the number of the question which place you want to change: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Choose the number of the second question which place the first question will be changed with: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Question temp = QuestionsArr[num1 - 1];
            QuestionsArr[num1 - 1] = QuestionsArr[num2 - 1];
            QuestionsArr[num2 - 1] = temp;
        }

        public void EditQuestionInTest()
        {

            System.Console.WriteLine("Which question you want to change: ");
            int numOfQ = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Do you want to change the text of the question? 1 - yes, 2 - no");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 1)
            {
                System.Console.WriteLine("Write your question: ");
                QuestionsArr[numOfQ - 1].QuestionText = Console.ReadLine();
            }
            System.Console.WriteLine("Do you want to change the type of the question? 1 - yes, 2 - no");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 1)
            {
                System.Console.WriteLine("Nothing is changed because types of questions do not exist.");
            }
            System.Console.WriteLine("Do you want to change the mark for the question? 1 - yes, 2 - no");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == 1)
            {
                System.Console.WriteLine("Choose the mark for this question: ");
                QuestionsArr[numOfQ - 1].Mark = Convert.ToInt32(Console.ReadLine());
            }
        }

    }

}