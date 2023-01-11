using System;

namespace project
{

    abstract class QuestionCreator
    {
        public abstract IQuestion FactoryMethod();

        public IQuestion CreateQuestion()
        {
            return FactoryMethod();
        }
    }

    class OneRightVariantQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new OneRightVariantQuestion();
        }
    }

    class SomeRightVariantsQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new SomeRightVariantsQuestion();
        }
    }

    class NoRightVariantQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new NoRightVariantQuestion();
        }
    }

    class DetailedAnswerCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new DetailedAnswer();
        }
    }

    class ConformityQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new ConformityQuestion();
        }
    }

    class ScaleQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new ScaleQuestion();
        }
    }

}