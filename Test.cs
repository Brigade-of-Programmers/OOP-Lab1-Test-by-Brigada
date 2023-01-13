﻿using System;
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

            set
            {
                this.resultOfTest = value;
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
            System.Console.WriteLine("Choose the type for this question: \n1. Text answer question;\n2. One right variant question;\n3. Some right variants question;\n4. Conformity question;\n5. No right answer question;\n6. Scale question;");
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
                    System.Console.WriteLine("You have automatically chosen text answer question!");
                    creator = new DetailedAnswerCreator();  
                    questionInTest = creator.FactoryMethod();
                    break;
            }
            QuestionsArr.Add(questionInTest);
            System.Console.WriteLine("Write your question: ");
            questionInTest.QuestionText = Console.ReadLine();
            System.Console.WriteLine("Choose the mark for this question: ");
            questionInTest.Mark = Convert.ToInt32(Console.ReadLine());
            switch (type)
            {
                case "1":
                    break;
                case "2":
                    System.Console.WriteLine("How many answers are you planning to write?");
                    int numOfOneVar = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter variants of answers:");
                    for(int i = 0; i < numOfOneVar; i++)
                    {
                        System.Console.WriteLine((i+1) + ":");
                        ((OneRightVariantQuestion)questionInTest).VariantAnswerArr.Add(Console.ReadLine());
                    }
                    break;
                case "3":
                    System.Console.WriteLine("How many answers are you planning to write?");
                    int numOfSomeVar = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter variants of answers:");
                    for(int i = 0; i < numOfSomeVar; i ++)
                    {
                        System.Console.WriteLine((i+1) + ":");
                        ((SomeRightVariantsQuestion)questionInTest).VariantAnswerArr.Add(Console.ReadLine());
                    }
                    break;
                case "4":
                    ((ConformityQuestion)questionInTest).EnterVariants();
                    break;
                case "5":
                    System.Console.WriteLine("How many answers are you planning to write?");
                    int numOfNoVar = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter variants of answers:");
                    for(int i = 0; i < numOfNoVar; i ++)
                    {
                        System.Console.WriteLine((i+1) + ":");
                        ((NoRightVariantQuestion)questionInTest).VariantAnswerArr.Add(Console.ReadLine());
                        ;
                    }
                    break;
                case "6":
                    Console.WriteLine("Your scale will have variants from 1 to 5.");
                    break;
                default:
                    break;
            }
            switch (type)
            {
                case "1":
                    System.Console.WriteLine("Choose right answer for this question: ");
                    ((DetailedAnswer)questionInTest).TextAnswer = Console.ReadLine();
                    break;
                case "2":
                    System.Console.WriteLine("Choose right answer for this question: ");
                    ((OneRightVariantQuestion)questionInTest).RightVariantAnswer = Console.ReadLine();
                    break;
                case "3":
                    System.Console.WriteLine("Choose right answer for this question: ");
                    System.Console.WriteLine("How many right answers are you planning?");
                    int numOfRight = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter right answers: ");
                    ((SomeRightVariantsQuestion)questionInTest).EnterCorrectAnswers(numOfRight);
                    break;
                case "4":
                    System.Console.WriteLine("Choose right answer for this question: ");
                    System.Console.WriteLine("How many right answers are you planning?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter right answers: ");
                    ((ConformityQuestion)questionInTest).EnterCorrectAnswers(amount);
                    break;
                case "5":
                    break;
                case "6":
                    System.Console.WriteLine("Choose right answer for this question: ");
                    ((ScaleQuestion)questionInTest).Scale = Console.ReadLine();
                    break;
                default:
                    System.Console.WriteLine("Choose right answer for this question: ");
                    ((DetailedAnswer)questionInTest).TextAnswer = Console.ReadLine();
                    break;
            }
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
                System.Console.WriteLine("Choose the type for this question: \n1.Text answer question;\n2. One right variant question;\n3. Some right variants question;\n4. Conformity question;\n5. No right answer question;\n 6. Scale question;");
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