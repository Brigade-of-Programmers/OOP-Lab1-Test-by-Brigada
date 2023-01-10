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
        private string userAnswer = "";

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
        
        public void MarkOfQuestion()
        {
            if (userAnswer != textAnswer)
            {
                Mark = 0;
            }
        }

        public void getUserAnswer()
        {
            TextAnswer = Console.ReadLine();
        }
    }
}
