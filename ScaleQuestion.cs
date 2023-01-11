using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ScaleQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private int userScale;
        private int scale;
        public int Scale
        {
            get
            {
                return scale;
            }

            set
            {
                if (value > 0 && value <= 5)
                {
                    this.scale = value;
                }
            }
        }

        public int UserScale
        {
            get
            {
                return this.userScale;
            }
            set
            {
                this.userScale = value;
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
            if (userScale != Scale)
            {
                Mark = 0;
            }
        }

        public void ShowVariants()
        {
            System.Console.WriteLine("You can choose one number from 1 to 5.");
        }

        public void GetUserAnswer(string answer)
        {
            UserScale = Convert.ToInt32(answer);
        }
    }
}
