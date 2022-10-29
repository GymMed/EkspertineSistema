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

        public void SetQuestion(string setQuestion)
        {
            setQuestion = TextFixer.Fix_Text(setQuestion);
            this.question = setQuestion;
        }

        public void SetAnswers(List<Answer> setAnswers)
        {
            this.answers = setAnswers;
        }
    }
}
