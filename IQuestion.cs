using System;

namespace project
{

    public interface IQuestion
    {
        void MarkOfQuestion();

        void ShowVariants();

        void EnterVariants();
        
        void EnterCorrectAnswers();

        void GetUserAnswer();

        string QuestionText
        { get; set; }

        int Mark
        { get; set; }
    }

}