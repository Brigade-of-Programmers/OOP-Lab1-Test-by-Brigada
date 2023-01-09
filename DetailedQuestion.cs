using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class DetailedAnswer : Question
    {
        private String textAnswer;

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

        public void getUserAnswer()
        {
            TextAnswer = Console.ReadLine();
        }
    }
}
