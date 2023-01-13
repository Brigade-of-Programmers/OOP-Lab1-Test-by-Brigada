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
        private List<String> userScale = new List<string>();
        private string scale;
        public string Scale
        {
            get
            {
                return scale;
            }

            set
            {
                if (Convert.ToInt32(value) > 0 && Convert.ToInt32(value) <= 5)
                {
                    this.scale = value;
                }
            }
        }

        public List<String> UserScale
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
            for (int i = 0; i < UserScale.Count; i++)
            {
                if (UserScale[i] != Scale)
                {
                    Mark = 0;
                }
            }
        }

        public void ShowVariants()
        {
            System.Console.WriteLine("You can choose one number from 1 to 5.");
        }

        public void GetUserAnswer(List<String> answer)
        {
            UserScale = answer;
        }
    }
}
