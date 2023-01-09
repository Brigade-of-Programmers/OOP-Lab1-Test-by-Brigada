using System;
using System.Collections.Generic;

namespace project
{
    class NoRightVariantQuestion : Question
    {
        private List<String> variantAsnwerArr = new List<String>();
        private List<String> userAnswer = new List<String>();
        public List<String> VariantAnswerArr
        {
            get
            {
                return this.variantAsnwerArr;
            }
            set
            {
                this.variantAsnwerArr = value;
            }
        }

        public List<String> UserAnswer
        {
            get
            {
                return this.userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }
    }
}
