using System;
using System.Collections.Generic;

namespace project
{
    public class Test
    {

        private List<IQuestion> questionsArr = new List<IQuestion>();
        private int resultOfTest;

        private string nameOfTest;

        public Test(string nameOfTest)
        {
            System.Console.WriteLine("Test <<" + nameOfTest + ">> has been created.");
            NameOfTest = nameOfTest;
        }

        public List<IQuestion> QuestionsArr
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
            QuestionCreator creator;
            IQuestion questionInTest;
            switch (type)
            {
                case "1":
                    creator = new DetailedAnswerCreator();   
                    questionInTest = creator.FactoryMethod();
                    break;
                case "2":
                    creator = new OneRightVariantQuestionCreator();
                    questionInTest = creator.FactoryMethod();
                    break;
                case "3":
                    creator = new SomeRightVariantsQuestionCreator();
                    questionInTest = creator.FactoryMethod();
                    break;
                case "4":
                    creator = new ConformityQuestionCreator();
                    questionInTest = creator.FactoryMethod();
                    break;
                case "5":
                    creator = new NoRightVariantQuestionCreator();
                    questionInTest = creator.FactoryMethod();
                    break;
                case "6":
                    creator = new ScaleQuestionCreator();
                    questionInTest = creator.FactoryMethod();
                    break;
                default:
                    creator = new DetailedAnswerCreator();  
                    questionInTest = creator.FactoryMethod();
                    break;
            }
            QuestionsArr.Add(questionInTest);
            System.Console.WriteLine("Write your question: ");
            questionInTest.QuestionText = Console.ReadLine();
            System.Console.WriteLine("Choose the mark for this question: ");
            questionInTest.Mark = Convert.ToInt32(Console.ReadLine());
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
            IQuestion temp = QuestionsArr[num1 - 1];
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
                System.Console.WriteLine("Choose the type for this question: /nText answer question;/n2. One right variant question;/n3. Some right variants question;/n4. Conformity question;/n5. No right answer question;/n 6. Scale question;");
                string type = Console.ReadLine();
                QuestionCreator creator;
                switch (type)
                {
                    case "1":
                        creator = new DetailedAnswerCreator();   
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    case "2":
                        creator = new OneRightVariantQuestionCreator();
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    case "3":
                        creator = new SomeRightVariantsQuestionCreator();
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    case "4":
                        creator = new ConformityQuestionCreator();
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    case "5":
                        creator = new NoRightVariantQuestionCreator();
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    case "6":
                        creator = new ScaleQuestionCreator();
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                    default:
                        creator = new DetailedAnswerCreator();  
                        QuestionsArr[numOfQ-1] = creator.FactoryMethod();
                        break;
                }

                System.Console.WriteLine("Type of you question is " + QuestionsArr[numOfQ-1].GetType());

            }
            else if (num2 == 2)
            {
                System.Console.WriteLine("Nothing is changed.");
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