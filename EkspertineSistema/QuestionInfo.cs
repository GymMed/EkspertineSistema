using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkspertineSistema
{
    class QuestionInfo
    {
        private string question;
        private List<Answer> answers;
        private int totalNewLines = 0;

        public QuestionInfo(string setQuestion, List<Answer> setListAnswers)
        {
            SetQuestion(setQuestion);
            this.answers = setListAnswers;
        }

        public string GetQuestion()
        {
            return this.question;
        }

        public List<Answer> GetAnswers()
        {
            return this.answers;
        }

        public int GetNewLines()
        {
            return totalNewLines;
        }

        public void SetQuestion(string setQuestion)
        {
            setQuestion = TextFixer.Fix_Text(setQuestion);
            totalNewLines = setQuestion.Split('\n').Length;
            this.question = setQuestion;
        }

        public void SetAnswers(List<Answer> setAnswers)
        {
            this.answers = setAnswers;
        }
    }
}
