using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ConformityQuestion : Question
    {
        private Dictionary<int, int> correctAnswers = new Dictionary<int, int>();
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
    }
}
