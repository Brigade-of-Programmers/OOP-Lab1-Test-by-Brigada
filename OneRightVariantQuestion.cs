using System;
using System.Collections.Generic;

namespace project
{
    class OneRightVariantQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private List<string> variantAsnwerArr = new List<string>();
        private string rightVariantAnswer = "";
        private string userAnswer = "";

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

        public string RightVariantAnswer
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

        public string UserAnswer
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
            if (userAnswer != rightVariantAnswer)
            {
                Mark = 0;
            }
        }

        public void ShowVariants()
        {
            for(int i = 0; i < variantAsnwerArr.Count; i ++)
            {
                System.Console.WriteLine((i+1) + ". " + variantAsnwerArr[i]);
            }
        }

        public void GetUserAnswer(string answer)
        {
            UserAnswer = answer;
        }
    }
}