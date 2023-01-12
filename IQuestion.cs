using System;

namespace project
{

    public interface IQuestion
    {
        void MarkOfQuestion();

        void ShowVariants();

        void GetUserAnswer(string answer);

        string QuestionText
        { get; set; }

        int Mark
        { get; set; }
    }

}