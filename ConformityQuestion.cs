using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ConformityQuestion : Question
    {
        private int counter = 0;
        private Dictionary<int, int> correctAnswers = new Dictionary<int, int>();
        private Dictionary<int, int> userAnswers = new Dictionary<int, int>();
        public int getAnswer(int numberOfQuestion)
        {
            int value;
            correctAnswers.TryGetValue(numberOfQuestion, out value);
            return value;
        }
        public void addAnswer(int numberOfQuestion, int answer)
        {
            correctAnswers.Add(numberOfQuestion, answer);
        }

        public void removeAnswer(int numberOfQuestion)
        {
            correctAnswers.Remove(numberOfQuestion);
        }
        
        public int getFinalMark()
        {
            for (int i = 0; i < correctAnswers.Count; i++)
            {
                int value;
                int userValue;
                correctAnswers.TryGetValue(i, out value);
                userAnswers.TryGetValue(i, out userValue);
                if (value == userValue) counter++;
            }
            return counter;
        }

        public void getUserAnswers()
        {
            int userAnswer;
            for (int i = 0; i < correctAnswers.Count; i++)
            {
                int userAnswer = Console.ReadLine();
                userAnswers.Add(i, userAnswer);
            }
        }
    }
}
