using System;
using System.Collections.Generic;

namespace project
{
    class OneRightVariantQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private List<string> variantAsnwerArr = new List<string>();
        private int rightVariantAnswer;
        private int userAnswer;


        public List<string> VariantAnswerArr
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

        public int RightVariantAnswer
        {
            get
            {
                return this.rightVariantAnswer;
            }
            set
            {
                this.rightVariantAnswer = value;
            }
        }

        public int UserAnswer
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
            if (UserAnswer != RightVariantAnswer)
            {
                Mark = 0;
            }
        }

        public void EnterVariants()
        {
            System.Console.WriteLine("Enter amount of variants: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter variants of answers:");
            for(int i = 0; i < amount; i++)
            {
                System.Console.WriteLine((i+1) + ":");
                VariantAnswerArr.Add(Console.ReadLine());
            }
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("Choose right answer for this question: ");
            RightVariantAnswer = Convert.ToInt32(Console.ReadLine());
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
            System.Console.WriteLine("Use only integers!");
            System.Console.WriteLine("Enter your answer: ");
            UserAnswer = Convert.ToInt32(Console.ReadLine()); 
        }
    }
}