using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkspertineSistema
{
    class Answer
    {
        private QuestionInfo questionInfo;
        private Conclusion conclusion;

        private string answer;

        public Answer(string setAnswer, QuestionInfo setQuestionInfo)
        {
            this.questionInfo = setQuestionInfo;
            SetAnswer(setAnswer);
        }

        public Answer(string setAnswer, Conclusion setConclusion)
        {
            this.conclusion = setConclusion;
            this.answer = setAnswer;
        }

        public void SetQuestionInfo(QuestionInfo setQuestionInfo)
        {
            this.questionInfo = setQuestionInfo;
        }

        public void SetAnswer(string setAnswer)
        {
            setAnswer = TextFixer.Fix_Text(setAnswer);
            this.answer = setAnswer;
        }

        public void SetConclusion(Conclusion setConclusion)
        {
            this.conclusion = setConclusion;
        }

        public QuestionInfo GetQuestionInfo()
        {
            return this.questionInfo;
        }

        public Conclusion GetConclusion()
        {
            return this.conclusion;
        }

        public string GetAnswer()
        {
            return this.answer;
        }
    }
}
