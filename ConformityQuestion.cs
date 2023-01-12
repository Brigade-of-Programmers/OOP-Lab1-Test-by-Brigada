using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ConformityQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private int counter = 0;

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
        private List<String> variantsQuestions = new List<String>();
        private List<String> variantsAnswers = new List<String>();
        private Dictionary<int, int> correctAnswers = new Dictionary<int, int>();
        private Dictionary<int, int> userAnswers = new Dictionary<int, int>();
        int amount;

        public void MarkOfQuestion()
        {
            for (int i = 0; i < amount; i++)
            {
                int value;
                int userValue;
                correctAnswers.TryGetValue(i, out value);
                userAnswers.TryGetValue(i, out userValue);
                if (value == userValue) counter++;
            }
            Mark = counter;
        }

        public void GetUserAnswer(string answer)
        {
            for (int i = 0; i < amount; i++)
            {
                userAnswers.Add(i, Convert.ToInt32(answer));
            }
        }

        public void EnterCorrectAnswers()
        {
            int correctAnswer;
            for (int i = 0; i < amount; i++)
            {
                correctAnswer = Convert.ToInt32(Console.ReadLine());
                correctAnswers.Add(i, correctAnswer);
            }
        }

        public void EnterVariants()
        {
            Console.WriteLine("Enter amount of variants: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter question variants: ");
            for (int i = 0; i < amount; i++)
            {
                variantsQuestions.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter answer variants: ");
            for (int i = 0; i < amount; i++)
            {
                variantsAnswers.Add(Console.ReadLine());
            }
        }

        public void ShowVariants()
        {
            Console.WriteLine("Question variants: ");
            foreach (String current in variantsQuestions)
            {
                Console.WriteLine(current);
            }
            Console.WriteLine("\nAnswer variants: ");
            foreach (String current in variantsAnswers)
            {
                Console.WriteLine(current);
            }
        }
    }
}
