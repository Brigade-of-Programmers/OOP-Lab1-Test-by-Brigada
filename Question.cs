using System;

namespace project{

    class Question{

        private string questionText;
        private int mark;

        public string QuestionText{

            get{
                return this.questionText;
            }

            set{
                this.questionText = value;
            }
            
        }

        public int Mark{

            get{
                return this.mark;
            }

            set{
                this.mark = value;
            }
            
        }

    }

}