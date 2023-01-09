using System;
using System.Collections.Generic;

namespace project
{
    class OneRightVariantQuestion : Question
    {
        private List<String> variantAsnwerArr = new List<String>();
        private String rightVariantAnswer = "";
        private String userAnswer = "";

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

        public String RightVariantAnswer
        {
            get
            {
                return this.rightVariantAnswer;
            }
            set
            {
                this.rightVariantAnswer = value;
            }
        }

        public String UserAnswer
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