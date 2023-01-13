using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class DetailedAnswer : IQuestion
    {
        private string questionText = "";
        private int mark;
        private String textAnswer = "";
        private List<string> userAnswer = new List<string>();

        public String TextAnswer
        {
            get
            {
                return textAnswer;
            }
            set
            {
                this.textAnswer = value;
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

        public List<string> UserAnswer
        {
            get
            {
                return userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }

        public void MarkOfQuestion()
        {
            for (int i = 0; i < UserAnswer.Count; i++)
            {
                if (userAnswer[i] != textAnswer)
                {
                    Mark = 0;
                }
            }
        }

        public void ShowVariants()
        {
            return;
        }

        public void GetUserAnswer(List<string> answer)
        {
            UserAnswer= answer;
        }
    }
}
