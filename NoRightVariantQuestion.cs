using System;
using System.Collections.Generic;

namespace project
{
    class NoRightVariantQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private List<String> variantAsnwerArr = new List<String>();
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

        public void EnterVariants()
        {
            System.Console.WriteLine("Enter amount of variants: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter variants of answers:");
            for(int i = 0; i < amount; i ++)
            {
                System.Console.WriteLine((i+1) + ":");
                VariantAnswerArr.Add(Console.ReadLine());
            }
        }

        public void EnterCorrectAnswers()
        {
            return;
        }

        public void MarkOfQuestion()
        {
            for (int i = 0; i < UserAnswer.Count; i++)
            {
                if(UserAnswer[i] > VariantAnswerArr.Count || UserAnswer[i] < 1)
                {
                    Mark = Mark - Mark/VariantAnswerArr.Count;
                }
            }
            return;
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
            System.Console.WriteLine("How many answers are you going to write?");
            int answerNumi;
            int amountOfAnsw = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Use only integers!");
            for (int i = 0; i < amountOfAnsw; i++)
            {
                System.Console.WriteLine((i+1) + ":");
                answerNumi = Convert.ToInt32(Console.ReadLine());
                UserAnswer.Add(answerNumi);
            }
        }

    }
}
