using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertineSistema
{
    class TwoQuestionPanel
    {
        private Panel mainPanel;
        private Label mainQuestionLabel;
        private Button yesButton, noButton;
        private QuestionInfo questionInformation;

        public TwoQuestionPanel(Panel mainPanel, Label mainQuestionLabel, Button yesButton, Button noButton, QuestionInfo questionInformation = null)
        {
            this.mainPanel = mainPanel;
            this.mainQuestionLabel = mainQuestionLabel;
            this.yesButton = yesButton;
            this.noButton = noButton;
            this.questionInformation = questionInformation;
        }

        public void ActivateQuestion()
        {
            if (questionInformation != null)
            {
                List<Answer> answers = this.questionInformation.GetAnswers();
                int totalAnswers = answers.Count;

                if (totalAnswers == 2)
                {
                    this.yesButton.Text = answers[0].GetAnswer();
                    this.noButton.Text = answers[1].GetAnswer();
                    this.mainQuestionLabel.Text = this.questionInformation.GetQuestion();
                }
                else
                {
                    MessageBox.Show("Klausimas turi turėti tik 2 atsakymus!");
                }
            }
        }

        public Answer YesButtonClick()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();

            return answers[0];
        }

        public Answer NoButtonClick()
        {
            List<Answer> answers = this.questionInformation.GetAnswers();

            return answers[1];
        }

        public Panel GetPanel()
        {
            return this.mainPanel;
        }

        public Label GetQuestionLabel()
        {
            return this.mainQuestionLabel;
        }

        public Button GetYesButton()
        {
            return this.yesButton;
        }

        public Button GetNoButton()
        {
            return this.noButton;
        }

        public void SetQuestionInformation(QuestionInfo setQuestionInformation)
        {
            this.questionInformation = setQuestionInformation;
        }
    }
}
