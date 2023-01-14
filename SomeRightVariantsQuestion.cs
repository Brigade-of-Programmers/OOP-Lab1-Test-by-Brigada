using System;
using System.Collections.Generic;

namespace project
{
    class SomeRightVariantsQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private List<String> variantAsnwerArr = new List<String>();
        private List<int> rightVariantsAnswer = new List<int>();
        private List<int> userAnswer = new List<int>();

        public List<String> VariantAnswerArr
        {
            get
            {
                return this.variantAsnwerArr;
            }
            set
            {
                this.variantAsnwerArr = value;
            }
        }

        public List<int> RightVariantsAnswer
        {
            get
            {
                return this.rightVariantsAnswer;
            }
            set
            {
                this.rightVariantsAnswer = value;
            }
        }

        public List<int> UserAnswer
        {
            get
            {
                return this.userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }

        public string QuestionText
        {
            get
            {
                return this.questionText;
            }

            set
            {
                this.questionText = value;
            }
        }

        public int Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                this.mark = value;
            }
        }

        public void MarkOfQuestion()
        {
            int counter = 0;
            for (int i = 0; i < userAnswer.Count; i++)
            {
                if (rightVariantsAnswer.Contains(userAnswer[i]))
                {
                    counter += Mark/rightVariantsAnswer.Count;
                }
            }
            Mark = counter;
        }

        public void EnterVariants()
        {
            System.Console.WriteLine("Enter amount of variants: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter variants of answers: ");
            for(int i = 0; i < amount; i ++)
            {
                System.Console.WriteLine((i+1) + ":");
                VariantAnswerArr.Add(Console.ReadLine());
            }
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("How many right answers are you planning?");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter right answers: ");
            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine((i+1) + ":");
                rightVariantsAnswer.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public void ShowVariants()
        {
            for (int i = 0; i < variantAsnwerArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". " + variantAsnwerArr[i]);
            }
        }

        public void GetUserAnswer()
        {
            System.Console.WriteLine("How many answers are you planning?");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Use only integers!");
            System.Console.WriteLine("Enter your answers: ");
            for (int i = 0; i < amount; i++)
            {
                System.Console.WriteLine((i+1) + ": ");
                UserAnswer.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}