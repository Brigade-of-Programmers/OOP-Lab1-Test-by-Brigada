﻿using System;
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

        public string UserAnswer
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
            if (UserAnswer != TextAnswer)
            {
                Mark = 0;
            }
        }

        public void EnterVariants()
        {
            return;
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("Choose right answer for this question: ");
            TextAnswer = Console.ReadLine();
        }

        public void ShowVariants()
        {
            return;
        }

        public void GetUserAnswer()
        {
            System.Console.WriteLine("Enter your answer: ");
            UserAnswer = Console.ReadLine();
        }
    }
}
