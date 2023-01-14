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
        private List<String> variantsQuestions = new List<String>();
        private List<String> variantsAnswers = new List<String>();
        private Dictionary<int, int> correctAnswers = new Dictionary<int, int>();
        private Dictionary<int, int> userAnswers = new Dictionary<int, int>();
        int amount;

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

        public List<String> VariantsQuestions
        {
            get
            {
                return this.variantsQuestions;
            }
            set
            {
                this.variantsQuestions = value;
            }
        }

        public List<String> VariantsAnswers
        {
            get
            {
                return this.variantsAnswers;
            }
            set
            {
                this.variantsAnswers = value;
            }
        }

        public Dictionary<int, int> CorrectAnswers
        {
            get
            {
                return this.correctAnswers;
            }
        }

        public Dictionary<int, int> UserAnswers
        {
            get
            {
                return this.userAnswers;
            }
        }

        public int Counter
        {
            get
            {
                return this.counter;
            }
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public void MarkOfQuestion()
        {
            for (int i = 0; i < amount; i++)
            {
                int value;
                int userValue;
                CorrectAnswers.TryGetValue(i, out value);
                UserAnswers.TryGetValue(i, out userValue);
                if (value == userValue) counter++;
            }
            Mark = Mark / counter;
        }

        public void GetUserAnswer()
        {
            System.Console.WriteLine("How many answers are you going to write?");
            int answerNumi;
            int amountOfAnsw = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Use only integers!");
            for (int i = 0; i < amountOfAnsw; i++)
            {
                System.Console.WriteLine((i + 1) + ":");
                answerNumi = Convert.ToInt32(Console.ReadLine());
                UserAnswers.Add(i, answerNumi);
            }
        }

        public void EnterCorrectAnswers()
        {
            System.Console.WriteLine("How many right answers are you planning?");
            int amount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter right answers: ");
            int correctAnswer;
            for (int i = 0; i < amount; i++)
            {
                correctAnswer = Convert.ToInt32(Console.ReadLine());
                CorrectAnswers.Add(i, correctAnswer);
            }
        }

        public void EnterVariants()
        {
            Console.WriteLine("Enter amount of variants: ");
            Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter question variants: ");
            for (int i = 0; i < Amount; i++)
            {
                VariantsQuestions.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter answer variants: ");
            for (int i = 0; i < Amount; i++)
            {
                VariantsAnswers.Add(Console.ReadLine());
            }
        }

        public void ShowVariants()
        {
            int i = 1;
            Console.WriteLine("Question variants: ");
            foreach (String current in VariantsQuestions)
            {
                Console.WriteLine(i + ". " + current);
                i++;
            }
            i = 1;
            Console.WriteLine("\nAnswer variants: ");
            foreach (String current in VariantsAnswers)
            {
                Console.WriteLine(i + ". " + current);
                i++;
            }
        }
    }
}
