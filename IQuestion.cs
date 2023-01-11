using System;

namespace project
{

    public interface IQuestion
    {
        public void MarkOfQuestion();

        public void ShowVariants();

        public void GetUserAnswer(string answer);

        public abstract string QuestionText
        {get; set;}

        public abstract int Mark
        {get; set;}
    }

}